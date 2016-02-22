using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using IBM.WMQ;
using System.Collections;

namespace ProyectoIDCode
{
    public class MQConexion
    {
        MQQueueManager queueManager;
        MQQueue queue;
        MQMessage queueMessage;
        MQPutMessageOptions queuePutMessageOptions;
        MQGetMessageOptions queueGetMessageOptions;


        static string QueueName;
        static string QueueManagerName;
        static string ChannelInfo;
        string channelName;
        string transportType;
        string connectionName;
        string message;

        public string ConnectMQ(string strQueueManagerName, string strQueueName,
        string strChannelInfo)
        {

            QueueManagerName = strQueueManagerName;
            QueueName = strQueueName;
            ChannelInfo = strChannelInfo;
            Hashtable table = new Hashtable();

            table.Add(MQC.HOST_NAME_PROPERTY, "192.168.1.37");
            table.Add(MQC.PORT_PROPERTY, 2414);
            table.Add(MQC.CHANNEL_PROPERTY, strChannelInfo);

            String strReturn = "";
            try
            {
                queueManager = new MQQueueManager(strQueueManagerName, table);
                strReturn = "Connected Successfully";
            }
            catch (MQException exp)
            {

                strReturn = "Exception: " + exp.Message;
            }
            return strReturn;
        }
        public string WriteMsg(string strInputMsg)
        {
            string strReturn = "";
            try
            {
                queue = queueManager.AccessQueue(QueueName,
                    MQC.MQOO_OUTPUT + MQC.MQOO_FAIL_IF_QUIESCING);

                message = strInputMsg;
                queueMessage = new MQMessage();
                queueMessage.WriteBytes(strInputMsg);
                queueMessage.ReplyToQueueName = "MBK.SESION3.SALIDA";
                queueMessage.OriginalLength = 120;
                queueMessage.ReplyToQueueManagerName = "IB9QMGR";
                queueMessage.DataOffset = 328;
                queueMessage.Format = MQC.MQFMT_STRING;
                queuePutMessageOptions = new MQPutMessageOptions();



                try
                {
                    queue.Put(queueMessage, queuePutMessageOptions);
                    strReturn = "Message sent to the queue successfully";
                }
                catch (MQException e)
                {
                    strReturn = "Exception: " + "error al colocar(put) el mensaje en la cola " + QueueName + ". " + e.ToString();
                }

            }
            catch (MQException MQexp)
            {
                strReturn = "Exception: " + MQexp.Message;
            }
            catch (Exception exp)
            {
                strReturn = "Exception: " + exp.Message;
            }
            return strReturn;
        }

        public string ReadMsg()
        {
            String strReturn = "";
            try
            {

                queue = queueManager.AccessQueue("MBK.SESION3.SALIDA",
                MQC.MQOO_INPUT_AS_Q_DEF + MQC.MQOO_FAIL_IF_QUIESCING);
                queueMessage = new MQMessage();
                queueMessage.Format = MQC.MQFMT_STRING;
                queueGetMessageOptions = new MQGetMessageOptions();
                queue.Get(queueMessage, queueGetMessageOptions);
                strReturn = queueMessage.ReadString(queueMessage.MessageLength);
            }
            catch (MQException MQexp)
            {
                strReturn = "Exception : " + MQexp.Message;
            }
            catch (Exception exp)
            {
                strReturn = "Exception: " + exp.Message;
            }
            return strReturn;
        }

    }
    
}