/* Basic reset */
body, h1, h2, h3, p, ul, li {
    margin: 0;
padding: 0;
font - family: Arial, sans-serif;
}

body {
    line-height: 1.6;
background - color: #f9f9f9;
}

.container {
    max-width: 1200px;
margin: 0 auto;
padding: 20px;
}

/* Header */
.site - header {
    background - color: #333;
    color: white;
padding: 20px 0;
display: flex;
    justify - content: space - between;
    align - items: center;
}

.logo {
    display: flex;
align - items: center;
}

.logo img
{
    height: 50px;
    margin-right: 10px;
}

.site - nav ul {
    list-style: none;
display: flex;
}

.site - nav ul li
{
    margin: 0 10px;
}

.site - nav ul li a {
    color: white;
text - decoration: none;
padding: 5px 10px;
border - radius: 5px;
}

.site - nav ul li a:hover {
    background-color: #555;
}

/* Main Content */
.content {
    margin: 20px 0;
}

/* Footer */
.site - footer {
    background - color: #333;
    color: white;
padding: 20px 0;
}

.footer - content {
display: flex;
    justify - content: space - between;
    align - items: flex - start;
}

.footer - content div {
    flex: 1;
padding: 0 10px;
}

.footer - nav ul {
    list-style: none;
}

.footer - nav ul li
{
    margin: 10px 0;
}

.footer - nav ul li a {
    color: white;
text - decoration: none;
}

.footer - nav ul li a:hover {
    text-decoration: underline;
}

.footer - bottom {
    text - align: center;
padding: 10px 0;
    border - top: 1px solid #444;
}

/* Home Page */
.home - hero {
    background - image: url('~/images/hero-background.jpg');
    background - size: cover;
    background - position: center;
color: white;
padding: 100px 20px;
    text - align: center;
}

.hero - content h1 {
    font-size: 3em;
margin - bottom: 20px;
}

.hero - content p {
    font-size: 1.5em;
margin - bottom: 30px;
}

.btn - primary {
padding: 10px 20px;
    background - color: #007bff;
    color: white;
    text - decoration: none;
    border - radius: 5px;
    font - size: 1.2em;
}

.home - intro {
margin: 40px 0;
    text - align: center;
}

.home - intro h2 {
    font-size: 2em;
margin - bottom: 20px;
}

.home - intro p {
    font-size: 1.2em;
margin - bottom: 20px;
}

.home - featured {
margin: 40px 0;
    text - align: center;
}

.featured - grid {
display: flex;
    flex - wrap: wrap;
    justify - content: center;
gap: 20px;
}

.featured - item {
    background - color: #f5f5f5;
    border: 1px solid #ddd;
    border - radius: 5px;
padding: 20px;
    max - width: 300px;
    text - align: left;
}

.featured - item img {
    width: 100 %;
height: auto;
border - radius: 5px;
margin - bottom: 10px;
}

.home - testimonials {
margin: 40px 0;
    text - align: center;
}

.testimonials - grid {
display: flex;
    flex - wrap: wrap;
    justify - content: center;
gap: 20px;
}

.testimonial - item {
    background - color: #f5f5f5;
    border: 1px solid #ddd;
    border - radius: 5px;
padding: 20px;
    max - width: 300px;
    text - align: left;
}

/* About Us Page */
.about - header {
    background - color: #f5f5f5;
    padding: 50px 20px;
    border - bottom: 1px solid #ddd;
    text - align: center;
}

.about - mission, .about - founder, .about - team {
margin: 40px 0;
    text - align: center;
}

.about - mission h2, .about-founder h2, .about-team h2 {
    font-size: 2em;
margin - bottom: 20px;
}

.founder - photo {
width: 150px;
height: 150px;
    border - radius: 50 %;
    margin - bottom: 20px;
}

.team - grid {
display: flex;
    flex - wrap: wrap;
    justify - content: center;
gap: 20px;
}

.team - member {
    background - color: #f5f5f5;
    border: 1px solid #ddd;
    border - radius: 5px;
padding: 20px;
    max - width: 300px;
    text - align: center;
}

.team - member img {
    width: 100px;
height: 100px;
border - radius: 50 %;
margin - bottom: 10px;
}

.team - member h3 {
    font-size: 1.5em;
margin - bottom: 10px;
}

/* Contact Us Page */
.contact - header {
    background - color: #f5f5f5;
    padding: 50px 20px;
    border - bottom: 1px solid #ddd;
    text - align: center;
}

.contact - form {
margin: 40px 0;
    text - align: left;
}

.contact - form form {
    max-width: 600px;
margin: 0 auto;
}

.form - group {
    margin - bottom: 20px;
}

.form - group label {
    display: block;
margin - bottom: 5px;
}

.form - group input,
.form-group textarea {
    width: 100 %;
padding: 10px;
border: 1px solid #ddd;
    border-radius: 5px;
}

.btn - submit {
display: inline - block;
padding: 10px 20px;
    background - color: #007bff;
    color: white;
    text - decoration: none;
    border - radius: 5px;
border: none;
cursor: pointer;
}

/* My Work Page */
.work - header {
    background - color: #f5f5f5;
    padding: 50px 20px;
    border - bottom: 1px solid #ddd;
    text - align: center;
}

.work - gallery {
display: flex;
    flex - wrap: wrap;
    justify - content: center;
gap: 20px;
margin: 40px 0;
}

.craft - item {
    background - color: #f5f5f5;
    border: 1px solid #ddd;
    border - radius: 5px;
padding: 20px;
    max - width: 300px;
    text - align: left;
}

.craft - photo {
width: 100 %;
height: auto;
    border - radius: 5px;
    margin - bottom: 10px;
}

.craft - details h2 {
    font-size: 1.5em;
margin - bottom: 10px;
}

.craft - details p {
    font-size: 1em;
margin - bottom: 10px;
}

