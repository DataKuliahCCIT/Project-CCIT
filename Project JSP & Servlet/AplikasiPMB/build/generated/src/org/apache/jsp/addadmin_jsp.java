package org.apache.jsp;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.jsp.*;
import java.sql.Statement;
import java.sql.Connection;
import java.sql.ResultSet;
import Model.Admin;
import Controller.Add_Admin;

public final class addadmin_jsp extends org.apache.jasper.runtime.HttpJspBase
    implements org.apache.jasper.runtime.JspSourceDependent {

  private static final JspFactory _jspxFactory = JspFactory.getDefaultFactory();

  private static java.util.List<String> _jspx_dependants;

  private org.glassfish.jsp.api.ResourceInjector _jspx_resourceInjector;

  public java.util.List<String> getDependants() {
    return _jspx_dependants;
  }

  public void _jspService(HttpServletRequest request, HttpServletResponse response)
        throws java.io.IOException, ServletException {

    PageContext pageContext = null;
    HttpSession session = null;
    ServletContext application = null;
    ServletConfig config = null;
    JspWriter out = null;
    Object page = this;
    JspWriter _jspx_out = null;
    PageContext _jspx_page_context = null;

    try {
      response.setContentType("text/html;charset=UTF-8");
      pageContext = _jspxFactory.getPageContext(this, request, response,
      			null, true, 8192, true);
      _jspx_page_context = pageContext;
      application = pageContext.getServletContext();
      config = pageContext.getServletConfig();
      session = pageContext.getSession();
      out = pageContext.getOut();
      _jspx_out = out;
      _jspx_resourceInjector = (org.glassfish.jsp.api.ResourceInjector) application.getAttribute("com.sun.appserv.jsp.resource.injector");

      out.write("\n");
      out.write("\n");
      out.write("\n");
      out.write("\n");
      out.write("\n");
      out.write("\n");
      out.write("\n");
      out.write("\n");
      out.write("<!DOCTYPE html>\n");
      out.write("<html>\n");
      out.write("<head>\n");
      out.write("<title>Tambah Admin | Administrator</title>\n");
      out.write("<meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\n");
      out.write("<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />\n");
      out.write("\t\n");
      out.write("\t<link rel=\"shortcut icon\" href=\"images/ico.ico\"/>\n");
      out.write("<script type=\"application/x-javascript\"> addEventListener(\"load\", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>\n");
      out.write("<!-- Bootstrap Core CSS -->\n");
      out.write("<link href=\"css/bootstrap.css\" rel='stylesheet' type='text/css' />\n");
      out.write("<!-- Custom CSS -->\n");
      out.write("<link href=\"css/style.css\" rel='stylesheet' type='text/css' />\n");
      out.write("<!-- font CSS -->\n");
      out.write("<link rel=\"icon\" href=\"favicon.ico\" type=\"image/x-icon\" >\n");
      out.write("<!-- font-awesome icons -->\n");
      out.write("<link href=\"css/font-awesome.css\" rel=\"stylesheet\"> \n");
      out.write("<!-- //font-awesome icons -->\n");
      out.write("<!-- chart -->\n");
      out.write("<script src=\"js/Chart.js\"></script>\n");
      out.write("<!-- //chart -->\n");
      out.write(" <!-- js-->\n");
      out.write("<script src=\"js/jquery-1.11.1.min.js\"></script>\n");
      out.write("<script src=\"js/modernizr.custom.js\"></script>\n");
      out.write("<!--webfonts-->\n");
      out.write("<link href='//fonts.googleapis.com/css?family=Roboto+Condensed:400,300,300italic,400italic,700,700italic' rel='stylesheet' type='text/css'>\n");
      out.write("<!--//webfonts--> \n");
      out.write("<!--animate-->\n");
      out.write("<link href=\"css/animate.css\" rel=\"stylesheet\" type=\"text/css\" media=\"all\">\n");
      out.write("<script src=\"js/wow.min.js\"></script>\n");
      out.write("\t<script>\n");
      out.write("\t\t new WOW().init();\n");
      out.write("\t</script>\n");
      out.write("<!--//end-animate-->\n");
      out.write("<!-- Metis Menu -->\n");
      out.write("<script src=\"js/metisMenu.min.js\"></script>\n");
      out.write("<script src=\"js/custom.js\"></script>\n");
      out.write("<link href=\"css/custom.css\" rel=\"stylesheet\">\n");
      out.write("        <link rel=\"stylesheet\" href=\"css/dataTables.bootstrap.css\">\n");
      out.write("\n");
      out.write("<!--//Metis Menu -->\n");
      out.write("</head> \n");
      out.write("<body class=\"cbp-spmenu-push\">\n");
      out.write("\t<div class=\"main-content\">\n");
      out.write("\t\t<!--left-fixed -navigation-->\n");
      out.write("\t\t<div class=\"sidebar\" role=\"navigation\">\n");
      out.write("            <div class=\"navbar-collapse\">\n");
      out.write("\t\t\t\t<nav class=\"cbp-spmenu cbp-spmenu-vertical cbp-spmenu-right dev-page-sidebar mCustomScrollbar _mCS_1 mCS-autoHide mCS_no_scrollbar\" id=\"cbp-spmenu-s1\">\n");
      out.write("\t\t\t\t\t<div class=\"scrollbar scrollbar1\">\n");
      out.write("\t\t\t\t\t\t <!-- extend base layout -->\n");
      out.write("\t\t\t\t\t</div>\n");
      out.write("\t\t\t\t\t<!-- //sidebar-collapse -->\n");
      out.write("\t\t\t\t</nav>\n");
      out.write("\t\t\t</div>\n");
      out.write("\t\t</div>\n");
      out.write("\t\t<!--left-fixed -navigation-->\n");
      out.write("\t\t<!-- header-starts -->\n");
      out.write("\t\t<div class=\"sticky-header header-section \">\n");
      out.write("\t\t\t<div class=\"header-left\">\n");
      out.write("\t\t\t\t<!--logo -->\n");
      out.write("\t\t\t\t<div class=\"logo\">\n");
      out.write("\t\t\t\t\t<a href=\"utama\">\n");
      out.write("\t\t\t\t\t\t<ul>\t\n");
      out.write("\t\t\t\t\t\t\t<li><img src=\"images/logo.png\" alt=\"\" /></li>\n");
      out.write("\t\t\t\t\t\t\t<li><h1>Dashboard</h1></li>\n");
      out.write("\t\t\t\t\t\t\t<div class=\"clearfix\"> </div>\n");
      out.write("\t\t\t\t\t\t</ul>\n");
      out.write("\t\t\t\t\t</a>\n");
      out.write("\t\t\t\t</div>\n");
      out.write("\t\t\t\t<!--//logo-->\n");
      out.write("\t\t\t\t<div class=\"header-right header-right-grid\">\n");
      out.write("\t\t\t\t\t<div class=\"profile_details_left\"><!--notifications of menu start -->\n");
      out.write("\t\t\t\t\t\t<ul class=\"nofitications-dropdown\">\n");
      out.write("\t\t\t\t\t\t\t\n");
      out.write("\t\t\t\t\t\t</ul>\n");
      out.write("\t\t\t\t\t\t<div class=\"clearfix\"> </div>\n");
      out.write("\t\t\t\t\t</div>\n");
      out.write("\t\t\t\t</div>\n");
      out.write("\t\t\t\t\n");
      out.write("\t\t\t\t\n");
      out.write("\t\t\t\t<div class=\"clearfix\"> </div>\n");
      out.write("\t\t\t</div>\n");
      out.write("\t\t\t<!--search-box-->\n");
      out.write("\t\t\t\t<div class=\"search-box\">\n");
      out.write("\t\t\t\t</div>\n");
      out.write("\t\t\t\t<!--//end-search-box-->\n");
      out.write("\t\t\t<div class=\"header-right\">\n");
      out.write("\t\t\t\t\n");
      out.write("\t\t\t\t<!--notification menu end -->\n");
      out.write("\t\t\t\t<div class=\"profile_details\">\t\t\n");
      out.write("\t\t\t\t</div>\n");
      out.write("\t\t\t\t<!--toggle button start-->\n");
      out.write("\t\t\t\t<button id=\"showLeftPush\"><i class=\"fa fa-bars\"></i></button>\n");
      out.write("\t\t\t\t<!--toggle button end-->\n");
      out.write("\t\t\t\t<div class=\"clearfix\"> </div>\t\t\t\t\n");
      out.write("\t\t\t</div>\n");
      out.write("\t\t\t<div class=\"clearfix\"> </div>\t\n");
      out.write("\t\t</div>\n");
      out.write("\t\t<!-- //header-ends -->\n");
      out.write("\t\t<!-- main content start-->\n");
      out.write("\t\t<div id=\"page-wrapper\">\n");
      out.write("\t\t\t<div class=\"main-page\">\n");
      out.write("\t\t\t\t\t<div class=\"col-md-12 text-center\"> \n");
      out.write("                                            \n");
      out.write("                                            <div class=\"col-md-8\">\n");
      out.write("                                                \n");
      out.write("\t\t\t\t\t\t\t<div class=\"panel panel-widget\">\n");
      out.write("                                                            <div class=\"input-info\">\n");
      out.write("\t\t\t\t\t\t\t\t\t\t<h3>Data Admin :</h3>\n");
      out.write("\t\t\t\t\t\t\t\t\t</div>\n");
      out.write("\t\t\t\t\t\t\t<div class=\"box-body table-responsive\">\n");
      out.write("                <table id=\"example1\" class=\"table table-bordered table-striped\">\n");
      out.write("                    <thead>\n");
      out.write("                        <tr>\n");
      out.write("                            <td>ID Admin</td>\n");
      out.write("                            <th>Nama</th>\n");
      out.write("                            <th>Username</th>\n");
      out.write("                        </tr>\n");
      out.write("                    </thead>\n");
      out.write("                    <tbody>\n");
      out.write("                   <tr>\n");
      out.write("                            <td>1</td>\n");
      out.write("                            <td>a</td>\n");
      out.write("                            <td>b</td>\n");
      out.write("                        </tr>      \n");
      out.write("                   <tr>\n");
      out.write("                            <td>2</td>\n");
      out.write("                            <td>c</td>\n");
      out.write("                            <td>d</td>\n");
      out.write("                        </tr>   \n");
      out.write("                   <tr>\n");
      out.write("                            <td>3</td>\n");
      out.write("                            <td>e</td>\n");
      out.write("                            <td>f</td>\n");
      out.write("                        </tr>   \n");
      out.write("                   <tr>\n");
      out.write("                            <td>4</td>\n");
      out.write("                            <td>f</td>\n");
      out.write("                            <td>s</td>\n");
      out.write("                        </tr>        \n");
      out.write("                    </tbody>\n");
      out.write("                    <tfoot>\n");
      out.write("                        <tr>\n");
      out.write("                            <td>ID Admin</td>\n");
      out.write("                            <th>Nama</th>\n");
      out.write("                            <th>Username</th>\n");
      out.write("                        </tr>\n");
      out.write("                    </tfoot>\n");
      out.write("                </table>\n");
      out.write("            </div><!-- /.box-body -->\n");
      out.write("                                                        </div>\n");
      out.write("\t\t\t\t\t</div>\n");
      out.write("                                            \n");
      out.write("                                            <div class=\"col-md-4\">\n");
      out.write("\t\t\t\t\t\t\t<div class=\"panel panel-widget\">\n");
      out.write("\t\t\t\t\t\t\t\t<div class=\"validation-grids widget-shadow\" data-example-id=\"basic-forms\"> \n");
      out.write("\t\t\t\t\t\t\t\t\t<div class=\"input-info\">\n");
      out.write("\t\t\t\t\t\t\t\t\t\t<h3>Tambah Admin :</h3>\n");
      out.write("            ");

                                    String result = (String)request.getAttribute("status");
                                    if(result != null)
                                    {
                                
      out.write("\n");
      out.write("                                <script language=\"javascript\">alert(\"");
 out.print(result); 
      out.write("\"); window.location = \"addadmin.jsp\";</script>\n");
      out.write("                              ");
 } 
      out.write("  \n");
      out.write("                              \n");
      out.write("\t\t\t\t\t\t\t\t\t</div>\n");
      out.write("\t\t\t\t\t\t\t\t\t<div class=\"form-body form-body-info\">\n");
      out.write("                                                                            <form method=\"POST\" action=\"Add_Admin\"  data-toggle=\"validator\" novalidate=\"true\" enctype=\"multipart/form-data\">\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t<div class=\"form-group valid-form\">\n");
      out.write("                                <input type=\"text\" class=\"form-control\" id=\"inputName\" value=\"");

                                    String idadmin = null;
        Admin auto = new Admin();
        idadmin = auto.autoidadmin();
      out.print(idadmin);  
      out.write("\" name=\"idadmin\" readonly=\"\" required=\"\">\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t</div>\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t<div class=\"form-group valid-form\">\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t\t<input type=\"text\" class=\"form-control\" data-minlength=\"6\" id=\"inputName\" name=\"nama\" placeholder=\"Nama..\" required=\"\">\n");
      out.write("                                                                                                <span class=\"help-block\">Nama Minimal 6 Karakter</span>\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t</div>\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t<div class=\"form-group has-feedback\">\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t\t<input type=\"text\" class=\"form-control\"  data-minlength=\"6\" id=\"inputName\" name=\"user\"  placeholder=\"Username..\" required=\"\">\n");
      out.write("                                                                                                <span class=\"help-block\">Username Minimal 6 Karakter</span>\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t</div>\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t  <input type=\"password\" data-toggle=\"validator\" name=\"password\" data-minlength=\"6\" class=\"form-control\" id=\"inputPassword\" placeholder=\"Password..\" required=\"\">\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t  <span class=\"help-block\">Password Minimal 6 Karakter</span>\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t</div>\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t  <input type=\"password\" class=\"form-control\" id=\"inputPasswordConfirm\" data-match=\"#inputPassword\" data-match-error=\"Password Tidak Sama!\" placeholder=\"Konfirmasi password..\" required=\"\">\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t  <div class=\"help-block with-errors\"></div>\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t</div>\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t\t<button type=\"submit\" class=\"btn btn-primary disabled\">Simpan</button>\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t</div>\n");
      out.write("\t\t\t\t\t\t\t\t\t\t</form>\n");
      out.write("\t\t\t\t\t\t\t\t\t</div>\n");
      out.write("\t\t\t\t\t\t\t\t</div>\n");
      out.write("\t\t\t\t\t\t\t</div>\n");
      out.write("\t\t\t\t\t</div>\n");
      out.write("\t\t\t\t</div>\n");
      out.write("\t\t\t\t<!--//row-->\n");
      out.write("\t\t\t</div>\n");
      out.write("\t\t</div>\n");
      out.write("\t\t<!--footer-->\n");
      out.write("\t\t <div class=\"dev-page\">\n");
      out.write("\t \n");
      out.write("\t\t\t<!-- page footer -->   \n");
      out.write("\t\t\t<!-- dev-page-footer-closed dev-page-footer-fixed -->\n");
      out.write("            <div class=\"dev-page-footer dev-page-footer-fixed\"> \n");
      out.write("\t\t\t\t<!-- container -->\n");
      out.write("\t\t\t\t<div class=\"container\">\n");
      out.write("\t\t\t\t\t<div class=\"copyright\">\n");
      out.write("\t\t\t\t\t</div>\n");
      out.write("                \n");
      out.write("                </div>\n");
      out.write("\t\t\t\t<!-- //container -->\n");
      out.write("            </div>\n");
      out.write("            <!-- /page footer -->\n");
      out.write("\t\t</div>\n");
      out.write("        <!--//footer-->\n");
      out.write("\t</div>\n");
      out.write("\t<!-- Classie -->\n");
      out.write("\t\t<script src=\"js/classie.js\"></script>\n");
      out.write("\t\t<script>\n");
      out.write("\t\t\tvar menuLeft = document.getElementById( 'cbp-spmenu-s1' ),\n");
      out.write("\t\t\t\tshowLeftPush = document.getElementById( 'showLeftPush' ),\n");
      out.write("\t\t\t\tbody = document.body;\n");
      out.write("\t\t\t\t\n");
      out.write("\t\t\tshowLeftPush.onclick = function() {\n");
      out.write("\t\t\t\tclassie.toggle( this, 'active' );\n");
      out.write("\t\t\t\tclassie.toggle( body, 'cbp-spmenu-push-toright' );\n");
      out.write("\t\t\t\tclassie.toggle( menuLeft, 'cbp-spmenu-open' );\n");
      out.write("\t\t\t\tdisableOther( 'showLeftPush' );\n");
      out.write("\t\t\t};\n");
      out.write("\t\t\t\n");
      out.write("\n");
      out.write("\t\t\tfunction disableOther( button ) {\n");
      out.write("\t\t\t\tif( button !== 'showLeftPush' ) {\n");
      out.write("\t\t\t\t\tclassie.toggle( showLeftPush, 'disabled' );\n");
      out.write("\t\t\t\t}\n");
      out.write("\t\t\t}\n");
      out.write("\t\t</script>\n");
      out.write("\t<!-- Bootstrap Core JavaScript --> \n");
      out.write("\t\t\n");
      out.write("        <script type=\"text/javascript\" src=\"js/bootstrap.min.js\"></script>\n");
      out.write("\n");
      out.write("        <script type=\"text/javascript\" src=\"js/dev-loaders.js\"></script>\n");
      out.write("        <script type=\"text/javascript\" src=\"js/dev-layout-default.js\"></script>\n");
      out.write("\t\t<script type=\"text/javascript\" src=\"js/jquery.marquee.js\"></script>\n");
      out.write("\t\t<link href=\"css/bootstrap.min.css\" rel=\"stylesheet\">\n");
      out.write("\t\t\n");
      out.write("\t\t<!-- candlestick -->\n");
      out.write("\t\t<script type=\"text/javascript\" src=\"js/jquery.jqcandlestick.min.js\"></script>\n");
      out.write("\t\t<link rel=\"stylesheet\" type=\"text/css\" href=\"css/jqcandlestick.css\" />\n");
      out.write("\t\t<!-- //candlestick -->\n");
      out.write("\t\t\n");
      out.write("\t\t<!--max-plugin-->\n");
      out.write("\t\t<script type=\"text/javascript\" src=\"js/plugins.js\"></script>\n");
      out.write("\t\t<!--//max-plugin-->\n");
      out.write("\t\t\n");
      out.write("\t\t<!--scrolling js-->\n");
      out.write("\t\t<script src=\"js/jquery.nicescroll.js\"></script>\n");
      out.write("\t\t<script src=\"js/scripts.js\"></script>\n");
      out.write("\t\t<!--//scrolling js-->\n");
      out.write("                \n");
      out.write("\t\t<script type=\"text/javascript\" src=\"js/valida.2.1.6.min.js\"></script>\n");
      out.write("\t\t<script type=\"text/javascript\" >\n");
      out.write("\n");
      out.write("\t\t\t$(document).ready(function() {\n");
      out.write("\n");
      out.write("\t\t\t\t// show Valida's version.\n");
      out.write("\t\t\t\t$('#version').valida( 'version' );\n");
      out.write("\n");
      out.write("\t\t\t\t// Exemple 1\n");
      out.write("\t\t\t\t$('.valida').valida();\n");
      out.write("\n");
      out.write("\t\t\t\t// Exemple 2\n");
      out.write("\t\t\t\t/*\n");
      out.write("\t\t\t\t$('.valida').valida({\n");
      out.write("\n");
      out.write("\t\t\t\t\t// basic settings\n");
      out.write("\t\t\t\t\tvalidate: 'novalidate',\n");
      out.write("\t\t\t\t\tautocomplete: 'off',\n");
      out.write("\t\t\t\t\ttag: 'p',\n");
      out.write("\n");
      out.write("\t\t\t\t\t// default messages\n");
      out.write("\t\t\t\t\tmessages: {\n");
      out.write("\t\t\t\t\t\tsubmit: 'Wait ...',\n");
      out.write("\t\t\t\t\t\trequired: 'Este campo é obrigatório',\n");
      out.write("\t\t\t\t\t\tinvalid: 'Field with invalid data',\n");
      out.write("\t\t\t\t\t\ttextarea_help: 'Digitados <span class=\"at-counter\">{0}</span> de {1}'\n");
      out.write("\t\t\t\t\t},\n");
      out.write("\n");
      out.write("\t\t\t\t\t// filters & callbacks\n");
      out.write("\t\t\t\t\tuse_filter: true,\n");
      out.write("\n");
      out.write("\t\t\t\t\t// a callback function that will be called right before valida runs.\n");
      out.write("\t\t\t\t\t// it must return a boolan value (true for good results and false for errors)\n");
      out.write("\t\t\t\t\tbefore_validate: null,\n");
      out.write("\n");
      out.write("\t\t\t\t\t// a callback function that will be called right after valida runs.\n");
      out.write("\t\t\t\t\t// it must return a boolan value (true for good results and false for errors)\n");
      out.write("\t\t\t\t\tafter_validate: null\n");
      out.write("\n");
      out.write("\t\t\t\t});\n");
      out.write("\t\t\t\t*/\n");
      out.write("\n");
      out.write("        // setup the partial validation\n");
      out.write("\t\t\t\t$('#partial-1').on('click', function( ev ) {\n");
      out.write("\t\t\t\t\tev.preventDefault();\n");
      out.write("\t\t\t\t\t$('#res-1').click(); // clear form error msgs\n");
      out.write("\t\t\t\t\t$('form').valida('partial', '#field-1'); // validate only field-1\n");
      out.write("\t\t\t\t\t$('form').valida('partial', '#field-1-3'); // validate only field-1-3\n");
      out.write("\t\t\t\t});\n");
      out.write("\n");
      out.write("\t\t\t});\n");
      out.write("\n");
      out.write("\t\t</script>\n");
      out.write("\t\t<!-- //input-forms -->\n");
      out.write("\t\t<!--validator js-->\n");
      out.write("\t\t<script src=\"js/validator.min.js\"></script>\n");
      out.write("                <script src=\"js/jquery.dataTables.min.js\"></script>\n");
      out.write("        <script src=\"js/dataTables.bootstrap.js\"></script>\t\n");
      out.write("        <script type=\"text/javascript\">\n");
      out.write("            $(function() {\n");
      out.write("                $('#example1').dataTable();\n");
      out.write("            });\n");
      out.write("        </script>\n");
      out.write("</body>\n");
      out.write("</html>\n");
      out.write("</html>\n");
    } catch (Throwable t) {
      if (!(t instanceof SkipPageException)){
        out = _jspx_out;
        if (out != null && out.getBufferSize() != 0)
          out.clearBuffer();
        if (_jspx_page_context != null) _jspx_page_context.handlePageException(t);
        else throw new ServletException(t);
      }
    } finally {
      _jspxFactory.releasePageContext(_jspx_page_context);
    }
  }
}
