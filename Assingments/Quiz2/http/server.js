const http = require("http");
function serverHandler(req, res) {
  if (req.url === "/") {
    res.write(
      "<h1>Hello Pak Aims Class</h1><p>This is my web class updated</p><a href='/about'>About Page</a>"
    );
    res.end();
  }
  if (req.url === "/about") {
    res.write("<h1>My Name is Usman Akram</h1>");
    res.end();
  }
  if (req.url === "/api/students") {
    res.write(JSON.stringify(["Usman", "Noman", "Ali", "Kashif"]));
    res.end();
  }
}
const server = http.createServer(serverHandler);
server.listen(4000);
console.log("server started at 4000....");
