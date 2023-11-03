using Microsoft.AspNetCore.Http;
using System.Drawing;
using WebApp;


//Ali Vahedi

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

Point p1 = new Point(1, 1);
Point p2 = new Point(2, 2);
Point p3 = new Point(3, 3);
Point p4 = new Point(4, 3);

var result = Class1.ArePointsCollinear(p1, p2, p3);
var showpoint = Class1.showpoints(p1, p2, p3);

var result2 = Class1.ArePointsCollinear(p1, p2, p4);
var showpoint2 = Class1.showpoints(p1, p2, p4);



app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync(Convert.ToString(result));
    await context.Response.WriteAsync(showpoint);

    await context.Response.WriteAsync(Convert.ToString(result2));
    await context.Response.WriteAsync(showpoint2);


});


app.Run();
