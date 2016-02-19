<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pagospendientes.aspx.cs" Inherits="ProyectoIDCode.pagos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <link href="css/bootstrap.min.css" rel="stylesheet"/>
    <link href="font-awesome/css/font-awesome.css" rel="stylesheet"/>
    <link href="css/plugins/iCheck/custom.css" rel="stylesheet"/>
    <link href="css/plugins/steps/jquery.steps.css" rel="stylesheet"/>
    <link href="css/animate.css" rel="stylesheet"/>
    <link href="css/style.css" rel="stylesheet"/>
    <form id="form1" runat="server">
<div id="wrapper">

    <nav class="navbar-default navbar-static-side" role="navigation">
        <div class="sidebar-collapse">
            <ul class="nav" id="side-menu">
                <li class="nav-header">
                    <div class="dropdown profile-element"> <span>
                            <img alt="image" class="img-circle" src="img/profile_small.jpg" />
                             </span>
                        <a data-toggle="dropdown" class="dropdown-toggle" href="#">
                            <span class="clear"> <span class="block m-t-xs"> <strong class="font-bold">Naruto Uzumaki</strong>
                             </span> <span class="text-muted text-xs block">Padre de familia <b class="caret"></b></span> </span> </a>
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
                    <a href="#"><i class="fa fa-desktop"></i> <span class="nav-label">App Views</span>  <span class="pull-right label label-primary">SPECIAL</span></a>
                    <ul class="nav nav-second-level">
                        <li><a href="form_wizard.aspx">Matrícula 2016</a></li>
                        <li><a href="profile.html">Notas Académicas</a></li>
                        <li ><a href="projects.html">Actualizar Datos</a></li>
                        <li><a href="project_detail.html">Datos Personales</a></li>
                        <li><a href="librospendientes.aspx">Libros pendientes</a></li>
                        <li class="active"><a href="pagos.aspx">Pagos y deudas</a></li>
                    </ul>
                </li>
                
            </ul>

        </div>
    </nav>

        <div id="page-wrapper" class="gray-bg">
        <div class="row border-bottom">
        <nav class="navbar navbar-static-top" role="navigation" style="margin-bottom: 0">
        <div class="navbar-header">
            <a class="navbar-minimalize minimalize-styl-2 btn btn-primary " href="#"><i class="fa fa-bars"></i> </a>
            
        </div>
            <ul class="nav navbar-top-links navbar-right">
                <li>
                    <span class="m-r-sm text-muted welcome-message">Bienbenido a la I.E.P. School++</span>
                </li>
                <li class="dropdown">
                    <a class="dropdown-toggle count-info" data-toggle="dropdown" href="#">
                        <i class="fa fa-envelope"></i>  <span class="label label-warning">16</span>
                    </a>
                    <ul class="dropdown-menu dropdown-messages">
                        <li>
                            <div class="dropdown-messages-box">
                                <a href="profile.html" class="pull-left">
                                    <img alt="image" class="img-circle" src="img/a7.jpg"/>
                                </a>
                                <div class="media-body">
                                    <small class="pull-right">46h ago</small>
                                    <strong>Mike Loreipsum</strong> started following <strong>Monica Smith</strong>. <br/>
                                    <small class="text-muted">3 days ago at 7:58 pm - 10.06.2014</small>
                                </div>
                            </div>
                        </li>
                        <li class="divider"></li>
                        <li>
                            <div class="dropdown-messages-box">
                                <a href="profile.html" class="pull-left">
                                    <img alt="image" class="img-circle" src="img/a4.jpg"/>
                                </a>
                                <div class="media-body ">
                                    <small class="pull-right text-navy">5h ago</small>
                                    <strong>Chris Johnatan Overtunk</strong> started following <strong>Monica Smith</strong>. <br/>
                                    <small class="text-muted">Yesterday 1:21 pm - 11.06.2014</small>
                                </div>
                            </div>
                        </li>
                        <li class="divider"></li>
                        <li>
                            <div class="dropdown-messages-box">
                                <a href="profile.html" class="pull-left">
                                    <img alt="image" class="img-circle" src="img/profile.jpg"/>
                                </a>
                                <div class="media-body ">
                                    <small class="pull-right">23h ago</small>
                                    <strong>Monica Smith</strong> love <strong>Kim Smith</strong>. <br/>
                                    <small class="text-muted">2 days ago at 2:30 am - 11.06.2014</small>
                                </div>
                            </div>
                        </li>
                        <li class="divider"></li>
                        <li>
                            <div class="text-center link-block">
                                <a href="mailbox.html">
                                    <i class="fa fa-envelope"></i> <strong>Read All Messages</strong>
                                </a>
                            </div>
                        </li>
                    </ul>
                </li>
                <li class="dropdown">
                    <a class="dropdown-toggle count-info" data-toggle="dropdown" href="#">
                        <i class="fa fa-bell"></i>  <span class="label label-primary">8</span>
                    </a>
                    <ul class="dropdown-menu dropdown-alerts">
                        <li>
                            <a href="mailbox.html">
                                <div>
                                    <i class="fa fa-envelope fa-fw"></i> You have 16 messages
                                    <span class="pull-right text-muted small">4 minutes ago</span>
                                </div>
                            </a>
                        </li>
                        <li class="divider"></li>
                        <li>
                            <a href="profile.html">
                                <div>
                                    <i class="fa fa-twitter fa-fw"></i> 3 New Followers
                                    <span class="pull-right text-muted small">12 minutes ago</span>
                                </div>
                            </a>
                        </li>
                        <li class="divider"></li>
                        <li>
                            <a href="grid_options.html">
                                <div>
                                    <i class="fa fa-upload fa-fw"></i> Server Rebooted
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
                        <i class="fa fa-sign-out"></i> Log out
                    </a>
                </li>
            </ul>

        </nav>
        </div>
            <div class="row wrapper border-bottom white-bg page-heading">
                <div class="col-lg-10">
                    <h2>Pagos y deudas</h2>
                    <ol class="breadcrumb">
                        <li>
                            <a href="index.html">Home</a>
                        </li>
                        <li>
                            <a>App Views</a>
                        </li>
                        <li class="active">
                            <strong>Pagos y deudas</strong>
                        </li>
                    </ol>
                </div>
                <div class="col-lg-2">

                </div>
            </div>
        <div class="wrapper wrapper-content animated fadeInRight">
            <div class="row">
                
                
                <div class="col-lg-4">
                    <div class="widget-head-color-box navy-bg p-lg text-center">
                        <div class="m-b-md">
                        <h2 class="font-bold no-margins">
                            Alex Smith
                        </h2>
                            <small>1° de Primaria</small>
                        </div>
                        <img src="img/a4.jpg" class="img-circle circle-border m-b-md" alt="profile"/>
                        <div>
                            <span>Pomedio Global: 17</span>
                        </div>
                    </div>
                    <div class="widget-text-box">
                        <h4 class="media-heading">Alex Smith</h4>
                        <p>Desempeño académico destacable.</p>
                        <div class="text-right">
                            <a class="btn btn-xs btn-white"><i class="fa fa-thumbs-up"></i> Like </a>
                            <a class="btn btn-xs btn-primary"><i class="fa fa-heart"></i> Love</a>
                        </div>
                    </div>
                </div>
                
                
                
                
                <div class="col-lg-8">
                    <div class="ibox float-e-margins">
                        <div class="ibox-title">
                            <h5>Pagos pendientes</h5>
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
                        <div class="ibox-content">

                            <asp:GridView ID="datos" runat="server" class="table table-hover" OnSelectedIndexChanged="datos_SelectedIndexChanged">

                            </asp:GridView>
                            <asp:Label ID="lblmensaje" runat="server" Text=""></asp:Label>

                            <!-- 
                            <table class="table table-hover">
                                <thead>
                                <tr>
                                    <th>#</th>
                                    <th>Nombre de deuda</th>
                                    <th>Deuda</th>
                                    <th>Saldo</th>
                                </tr>
                                </thead>
                                <tbody>
                                <tr>
                                    <td>1</td>
                                    <td>Pensión Mes Noviembre</td>
                                    <td class="text-navy"> <i class="fa fa-money"></i> 1500.00 </td>
                                    <td class="text-warning"> <i class="fa fa-money"></i> 0.00 </td>
                                </tr>
                                <tr>
                                    <td>2</td>
                                    <td>Pensión Mes Diciembre</td>
                                    <td class="text-navy"> <i class="fa fa-money"></i> 1500.00 </td>
                                    <td class="text-warning"> <i class="fa fa-money"></i> 1500.00 </td>
                                </tr>
                                <tr>
                                    <td>3</td>
                                    <td>Taller de Computo</td>
                                    <td class="text-navy"> <i class="fa fa-money"></i> 500.00 </td>
                                    <td class="text-warning"> <i class="fa fa-money"></i> 500.00 </td>
                                </tr>
                                </tbody>
                            </table>
                            -->
                        </div>
                    </div>
                </div>
                <!--<div class="col-lg-5">
                    <div class="jumbotron">
                        <h1>Notas</h1>
                        <p>Para finalizar la reserva de matricula, usted deberá de pasar las siguientes restricciones.</p>
                        <p><a href="#"  class="btn btn-primary btn-lg" role="button">Ver video de ayuda</a>
                        </p>
                    </div>
                </div>-->
                
                <!--<div class="col-lg-7">
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
                    <div class="ibox-content">
                        <p>
                            Validar las siguientes restrciones
                        </p>
                        <div id="wizard">
                            <h1>Situacion Académica</h1>
                            <div class="step-content">
                                <div class="text-center m-t-md">
                                <h2>Aprobado</h2>
                                <p>
                                    EL Alumno no debe nunguna materia académica.
                                </p>
                                </div>
                            </div>

                            <h1>Devolución de libros</h1>
                            <div class="step-content">
                                <div class="text-center m-t-md">
                                    <h2>Completo</h2>
                                    <p>
                                        El alumno no presenta ningun prestamo de libro pendiente.
                                    </p>
                                </div>
                            </div>

                            <h1>Estado de deudas</h1>
                            <div class="step-content">
                                <div class="text-center m-t-md">
                                    <h2>Cancelado</h2>
                                    <p>
                                        El alumno no presenta ninguna deuda pendiente.
                                    </p>
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
            </div>-->
                
                
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
            $("#wizard").steps();
            $("#form").steps({
                bodyTag: "fieldset",
                onStepChanging: function (event, currentIndex, newIndex) {
                    // Always allow going backward even if the current step contains invalid fields!
                    if (currentIndex > newIndex) {
                        return true;
                    }

                    // Forbid suppressing "Warning" step if the user is to young
                    if (newIndex === 3 && Number($("#age").val()) < 18) {
                        return false;
                    }

                    var form = $(this);

                    // Clean up if user went backward before
                    if (currentIndex < newIndex) {
                        // To remove error styles
                        $(".body:eq(" + newIndex + ") label.error", form).remove();
                        $(".body:eq(" + newIndex + ") .error", form).removeClass("error");
                    }

                    // Disable validation on fields that are disabled or hidden.
                    form.validate().settings.ignore = ":disabled,:hidden";

                    // Start validation; Prevent going forward if false
                    return form.valid();
                },
                onStepChanged: function (event, currentIndex, priorIndex) {
                    // Suppress (skip) "Warning" step if the user is old enough.
                    if (currentIndex === 2 && Number($("#age").val()) >= 18) {
                        $(this).steps("next");
                    }

                    // Suppress (skip) "Warning" step if the user is old enough and wants to the previous step.
                    if (currentIndex === 2 && priorIndex === 3) {
                        $(this).steps("previous");
                    }
                },
                onFinishing: function (event, currentIndex) {
                    var form = $(this);

                    // Disable validation on fields that are disabled.
                    // At this point it's recommended to do an overall check (mean ignoring only disabled fields)
                    form.validate().settings.ignore = ":disabled";

                    // Start validation; Prevent form submission if false
                    return form.valid();
                },
                onFinished: function (event, currentIndex) {
                    var form = $(this);

                    // Submit form input
                    form.submit();
                }
            }).validate({
                errorPlacement: function (error, element) {
                    element.before(error);
                },
                rules: {
                    confirm: {
                        equalTo: "#password"
                    }
                }
            });
        });
    </script>
    </form>
</body>
</html>
