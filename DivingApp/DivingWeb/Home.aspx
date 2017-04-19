<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <!-- Slider -->
        <div class="mp-slider">
            <ul class="items">
                <li><img src="images/slide-1.jpg" alt="" /><div class="banner"><span class="row-1"><b>See</b> the Underwater World</span><span class="row-2">With Your Own <b>Eyes</b></span></div></li>
                <li><img src="images/slide-2.jpg" alt="" /><div class="banner"><span class="row-1"><b>All</b> the Beauty</span><span class="row-2">of the Deep <b>Sea</b></span></div></li>
                <li><img src="images/slide-3.jpg" alt="" /><div class="banner"><span class="row-1"><b>Find</b> the treasures</span><span class="row-2">of the water <b>World</b></span></div></li>
            </ul>
            <a href="#" class="mp-prev"></a>
            <a href="#" class="mp-next"></a>
        </div>
        <!-- Content -->
        <section id="content"><div class="ic">More Website Templates @ TemplateMonster.com. August20, 2012!</div>
            <div class="container_12">
            	<article class="a1">
                	<div class="wrapper">
                        <img src="images/page1-img1.png" alt="" class="img-indent">
                        <div class="extra-wrap">
                            <h3>
                                <span class="welcome">Welcome
                                To The Wonderful Sea World</span>
                            </h3>
                            <p class="p1">
                                <a href="http://blog.templatemonster.com/free-website-templates/">Click here</a> for more info about this free web templates created by TemplateMonster.com. This website template is optimized for 1280X1024 screen resolution. It is also XHTML & CSS valid. The PSD source files of this template are available for free for the registered members of TemplateMonster.com. Feel free to get them!
                            </p>
                        </div> 
                    </div>
                </article>
                <article class="content-box">
                	<h3 class="hp-1">Upcoming Events:</h3>
                    <div class="wrapper">
                    	<div class="col-1">
                        	<figure class="img-box">
                            	<img src="images/page1-img2.jpg" alt="">
                            </figure>
                            <h5><span>31</span>Jan, 2014</h5>
                            <p>
                            	Nam liber tempor cumuod soluta nobis eleifend option congue imperdiet doming id quod mazim placerat.
                            </p>
                        </div>
                        <div class="col-1">
                        	<figure class="img-box">
                            	<img src="images/page1-img3.jpg" alt="">
                            </figure>
                            <h5><span>21</span> Feb, 2014</h5>
                            <p>
                            	Lorem ipsum dolor amet, consectetuer adipiscing elitom nonummy nibh euismod tincidunt ut laoreet dolore magna.
                            </p>
                        </div>
                        <div class="col-2">
                        	<figure class="img-box">
                            	<img src="images/page1-img4.jpg" alt="">
                            </figure>
                            <h5><span>03</span> Mar, 2014</h5>
                            <p>
                            	Ut wisi enim ad minim veniam, quis nostrd exerci tation ullamcorper suscipit lobortis nisl ut aliquip.
                            </p>
                        </div>
                    </div>
                </article>
            </div>
        </section>
</asp:Content>

