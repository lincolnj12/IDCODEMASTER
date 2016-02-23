<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="form_wizard.aspx.cs" Inherits="ProyectoIDCode.form_wizard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style type="text/css">
        #bloqueoPagina {
            background: #000000;
            width: 100%;
            height: 1100px;
            opacity: 0.7;
            margin: 0px;
            position: absolute;
            left: 0px;
            top: 0px;
            right: 0px;
            z-index: 1000;
            margin: 0px;
            padding: 0px; /* display: none;*/
        }
        #bloqueoPagina2 {
            background: #000000;
            width: 100%;
            height: 1100px;
            opacity: 0.7;
            margin: 0px;
            position: absolute;
            left: 0px;
            top: 0px;
            right: 0px;
            z-index: 1000;
            margin: 0px;
            padding: 0px; /* display: none;*/
        }

        #bloqueoPagina2 {
            background: #000000;
            width: 100%;
            height: 1100px;
            opacity: 0.7;
            margin: 0px;
            position: absolute;
            left: 0px;
            top: 0px;
            right: 0px;
            z-index: 1000;
            margin: 0px;
            padding: 0px; /* display: none;*/
        }

        #Mensaje {
            z-index: 10001;
            position: absolute;
            margin: 150px 140px 0 200px;
            background-color: #FFFFFF;
            top: 99px;
            left: 354px;
        }

            #Mensaje p {
                color: #000;
            }
    </style>
</head>
<body>

    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

    <title>School++</title>

    <link href="css/bootstrap.min.css" rel="stylesheet">
    <link href="font-awesome/css/font-awesome.css" rel="stylesheet">
    <link href="css/plugins/iCheck/custom.css" rel="stylesheet">
    <link href="css/plugins/steps/jquery.steps.css" rel="stylesheet">
    <link href="css/animate.css" rel="stylesheet">
    <link href="css/style.css" rel="stylesheet">
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
                <asp:Panel runat="server" ID="pnl_mensajeFinal" Visible="false">
                    <div id="bloqueoPagina"></div>

                    <div id="Mensaje" class="ibox-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal"><span aria-hidden="true">&times;</span><span class="sr-only">Close</span></button>
                            <i class="fa fa-clock-o modal-icon"></i>
                            <h4 class="modal-title">Reserva 2016</h4                            
                        </div>
                        <div class="modal-body">
                            <table>
                                <%--<tr>
                                    <td>Codigo unico de matricula :</td>
                                    <td>
                                        <asp:Label ID="lblmsj1" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>--%>
                                <tr>
                                    <td><asp:Label ID="lbltitulo1" runat="server" Text="Pago a realizar :" ></asp:Label> </td>
                                    <td>
                                        <asp:Label ID="lblmsj1" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td><asp:Label ID="lbltitulo2" runat="server" Text="Fecha de reserva :" ></asp:Label> </td>
                                    <td>
                                        <asp:Label ID="lblmsj2" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Button runat="server" ID="btn_aceptar" Text="Aceptar" OnClick="btn_aceptar_Click" class="btn btn-primary btn-sm"></asp:Button>
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>

                </asp:Panel>

                <asp:Panel runat="server" ID="Panel1" Visible="false">
                    <div id="bloqueoPagina2"></div>
                    <div id="Mensaje2" class="ibox-content">
                    </div>
                </asp:Panel>

            </ContentTemplate>
        </asp:UpdatePanel>

        <div id="wrapper">
            <nav class="navbar-default navbar-static-side" role="navigation">
                <div class="sidebar-collapse">
                    <ul class="nav" id="side-menu">
                        <li class="nav-header">
                            <div class="dropdown profile-element">
                                <span>
                                    <img alt="image" class="img-circle" src="img/profile_small.jpg" />
                                </span>
                                <a data-toggle="dropdown" class="dropdown-toggle" href="#">
                                    <span class="clear"><span class="block m-t-xs"><strong class="font-bold">Naruto Uzumaki</strong>
                                    </span><span class="text-muted text-xs block">Padre de familia <b class="caret"></b></span></span></a>
                                <ul class="dropdown-menu animated fadeInRight m-t-xs">
                                    <li><a href="profile.html">Mis datos</a></li>
                                    <li class="divider"></li>
                                    <li><a href="login.html">Salir</a></li>
                                </ul>
                            </div>
                            <div class="logo-element">
                                SCH+
                            </div>
                        </li>

                        <li class="active">
                            <a href="#"><i class="fa fa-desktop"></i><span class="nav-label">App Views</span>  <span class="pull-right label label-primary">SPECIAL</span></a>
                            <ul class="nav nav-second-level">
                                <li class="active"><a href="form_wizard.aspx">Matrícula 2016</a></li>    
                                <li><a href="librospendientes.aspx">Libros pendientes</a></li>
                                <li><a href="pagospendientes.aspx">Pagos y deudas</a></li>
                                <li><a href="cancelarMatricula.aspx">Cancelar Reserva</a></li>
								<li><a href="observaciones.aspx">Observaciones</a></li>
                                <li><a href="datos.aspx">Actualizar datos</a></li>
                            </ul>
                        </li>

                    </ul>

                </div>
            </nav>

            <div id="page-wrapper" class="gray-bg">
                <div class="row border-bottom">
                    <nav class="navbar navbar-static-top" role="navigation" style="margin-bottom: 0">
                        <div class="navbar-header">
                            <a class="navbar-minimalize minimalize-styl-2 btn btn-primary " href="#"><i class="fa fa-bars"></i></a>

                        </div>
                        <ul class="nav navbar-top-links navbar-right">
                            <li>
                                <span class="m-r-sm text-muted welcome-message">Bienbenido a la I.E.P. School++</span>
                            </li>
                            <li class="dropdown">
                                <a class="dropdown-toggle count-info" data-toggle="dropdown" href="#">
                                    <i class="fa fa-envelope"></i><span class="label label-warning">16</span>
                                </a>
                                <ul class="dropdown-menu dropdown-messages">
                                    <li>
                                        <div class="dropdown-messages-box">
                                            <a href="profile.html" class="pull-left">
                                                <img alt="image" class="img-circle" src="img/a7.jpg">
                                            </a>
                                            <div class="media-body">
                                                <small class="pull-right">46h ago</small>
                                                <strong>Mike Loreipsum</strong> started following <strong>Monica Smith</strong>.
                                                <br>
                                                <small class="text-muted">3 days ago at 7:58 pm - 10.06.2014</small>
                                            </div>
                                        </div>
                                    </li>
                                    <li class="divider"></li>
                                    <li>
                                        <div class="dropdown-messages-box">
                                            <a href="profile.html" class="pull-left">
                                                <img alt="image" class="img-circle" src="img/a4.jpg">
                                            </a>
                                            <div class="media-body ">
                                                <small class="pull-right text-navy">5h ago</small>
                                                <strong>Chris Johnatan Overtunk</strong> started following <strong>Monica Smith</strong>.
                                                <br>
                                                <small class="text-muted">Yesterday 1:21 pm - 11.06.2014</small>
                                            </div>
                                        </div>
                                    </li>
                                    <li class="divider"></li>
                                    <li>
                                        <div class="dropdown-messages-box">
                                            <a href="profile.html" class="pull-left">
                                                <img alt="image" class="img-circle" src="img/profile.jpg">
                                            </a>
                                            <div class="media-body ">
                                                <small class="pull-right">23h ago</small>
                                                <strong>Monica Smith</strong> love <strong>Kim Smith</strong>.
                                                <br>
                                                <small class="text-muted">2 days ago at 2:30 am - 11.06.2014</small>
                                            </div>
                                        </div>
                                    </li>
                                    <li class="divider"></li>
                                    <li>
                                        <div class="text-center link-block">
                                            <a href="mailbox.html">
                                                <i class="fa fa-envelope"></i><strong>Read All Messages</strong>
                                            </a>
                                        </div>
                                    </li>
                                </ul>
                            </li>
                            <li class="dropdown">
                                <a class="dropdown-toggle count-info" data-toggle="dropdown" href="#">
                                    <i class="fa fa-bell"></i><span class="label label-primary">8</span>
                                </a>
                                <ul class="dropdown-menu dropdown-alerts">
                                    <li>
                                        <a href="mailbox.html">
                                            <div>
                                                <i class="fa fa-envelope fa-fw"></i>You have 16 messages
                                    <span class="pull-right text-muted small">4 minutes ago</span>
                                            </div>
                                        </a>
                                    </li>
                                    <li class="divider"></li>
                                    <li>
                                        <a href="profile.html">
                                            <div>
                                                <i class="fa fa-twitter fa-fw"></i>3 New Followers
                                    <span class="pull-right text-muted small">12 minutes ago</span>
                                            </div>
                                        </a>
                                    </li>
                                    <li class="divider"></li>
                                    <li>
                                        <a href="grid_options.html">
                                            <div>
                                                <i class="fa fa-upload fa-fw"></i>Server Rebooted
                                    <span class="pull-right text-muted small">4 minutes ago</span>
                                            </div>
                                        </a>
                                    </li>
                                    <li class="divider"></li>
                                    <li>
                                        <div class="text-center link-block">
                                            <a href="notifications.html">
                                                <strong>See All Alerts</strong>
                                                <i class="fa fa-angle-right"></i>
                                            </a>
                                        </div>
                                    </li>
                                </ul>
                            </li>


                            <li>
                                <a href="login.html">
                                    <i class="fa fa-sign-out"></i>Log out
                                </a>
                            </li>
                        </ul>

                    </nav>
                </div>
                <div class="row wrapper border-bottom white-bg page-heading">
                    <div class="col-lg-10">
                        <h2>Reserva de matrícula 2016</h2>
                        <ol class="breadcrumb">
                            <li>
                                <a href="index.aspx">Home</a>
                            </li>
                            <li>
                                <a>App Views</a>
                            </li>
                            <li class="active">
                                <strong>Reserva</strong>
                            </li>
                        </ol>
                    </div>
                    <div class="col-lg-2">
                    </div>
                </div>
                <div class="wrapper wrapper-content animated fadeInRight">
                    <div class="row">
                        <div class="col-lg-5">
                            <div class="jumbotron">
                                <h1>Reserva</h1>
                                <p>Para finalizar la reserva de matricula, usted deberá de pasar las siguientes restricciones.</p>
                                <p>
                                    <a href="#" class="btn btn-primary btn-lg" role="button">Ver video de ayuda</a>
                                </p>
                            </div>
                        </div>
                        <div class="col-lg-7">
                            <div class="ibox float-e-margins">
                                <div class="ibox-title">
                                    <h5>Proceso de reserva matrícula 2016</h5>
                                    <div class="ibox-tools">
                                        <a class="collapse-link">
                                            <i class="fa fa-chevron-up"></i>
                                        </a>
                                        <a class="dropdown-toggle" data-toggle="dropdown" href="#">
                                            <i class="fa fa-wrench"></i>
                                        </a>
                                        <ul class="dropdown-menu dropdown-user">
                                            <li><a href="#">Config option 1</a>
                                            </li>
                                            <li><a href="#">Config option 2</a>
                                            </li>
                                        </ul>
                                        <a class="close-link">
                                            <i class="fa fa-times"></i>
                                        </a>
                                    </div>
                                </div>
                                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                    <ContentTemplate>




                                        <div class="ibox-content">
                                            <p>
                                                Validar las siguientes restrciones
                                            </p>
                                            <div <%--id="wizard"--%>>
                                                <%--<h1>Situacion Académica</h1>--%>
                                                <asp:Button ID="btnsitacademica" runat="server" Text="Situacion Académica" class="btn btn-primary btn-sm" OnClick="btnsitacademica_Click" />


                                                <%--<h1>Devolución de libros</h1>--%>
                                                <asp:Button ID="btndevolucion" runat="server" Text="Devolución de libros" class="btn btn-primary btn-sm" OnClick="btndevolucion_Click" />


                                                <%--<h1>Estado de deudas</h1>--%>
                                                <asp:Button ID="btnestadoD" runat="server" Text="Estado de deudas" class="btn btn-primary btn-sm" OnClick="btnestadoD_Click" />
                                                <div class="ibox-content">


                                                    <table>
                                                        <tr>
                                                            <td>
                                                                <asp:Label ID="lblmensaje" runat="server" Text="Label"></asp:Label>

                                                            </td>
                                                        </tr>
                                                    </table>

                                                </div>
                                            </div>
                                            <div>
                                                <table>
                                                    <tr>
                                                        <td>
                                                            <asp:Button ID="btcontinuar" runat="server" Text="Continuar" class="btn btn-primary btn-sm" OnClick="btcontinuar_Click" />
                                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                        </td>
                                                        <td>
                                                            <asp:Button ID="btnfinish" runat="server" Text="Reservar" class="btn btn-primary btn-sm" OnClick="btnfinish_Click" />
                                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                        </td>
                                                        <td>
                                                            <asp:Button ID="btncancel" runat="server" Text="Cancel" class="btn btn-primary btn-sm" OnClick="btncancel_Click" />
                                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                        </td>
                                                    </tr>

                                                </table>
                                            </div>
                                        </div>
                                    </ContentTemplate>
                                </asp:UpdatePanel>

                            </div>
                        </div>
                    </div>

                </div>
                <div class="footer">
                    <div class="pull-right">
                        10GB of <strong>250GB</strong> Free.
                    </div>
                    <div>
                        <strong>Copyright</strong> Example Company &copy; 2014-2015
                    </div>
                </div>

            </div>
        </div>



        <!-- Mainly scripts -->
        <script src="js/jquery-2.1.1.js"></script>
        <script src="js/bootstrap.min.js"></script>
        <script src="js/plugins/metisMenu/jquery.metisMenu.js"></script>
        <script src="js/plugins/slimscroll/jquery.slimscroll.min.js"></script>

        <!-- Custom and plugin javascript -->
        <script src="js/inspinia.js"></script>
        <script src="js/plugins/pace/pace.min.js"></script>

        <!-- Steps -->
        <script src="js/plugins/staps/jquery.steps.min.js"></script>

        <!-- Jquery Validate -->
        <script src="js/plugins/validate/jquery.validate.min.js"></script>


        <script>

            $(document).ready(function () {



                $("#wizard").steps({
                    startIndex: 0,
                    enableFinishButton: false,
                    enablePagination: false,
                });
            });

        </script>

    </form>
</body>
</html>
