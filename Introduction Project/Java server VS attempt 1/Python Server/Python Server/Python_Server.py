import http.server
import socketserver

PORT = 42069
Handler = http.server.SimpleHTTPRequestHandler

with socketserver.TCPServer(( "145.93.62.204", PORT), Handler) as httpd:
    #httpd = socketserver.TCPServer((“”, PORT), Handler) or use this
    print("Serving at port: ", PORT)
    httpd.serve_forever()
