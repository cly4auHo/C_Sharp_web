﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebSocketsExample.Services;

namespace WebSocketsExample.Controllers
{
    public class StreamController : Controller
    {
        private readonly WebSocketHandler _webSocketHandler;

        public StreamController(WebSocketHandler webSocketHandler)
        {
            _webSocketHandler = webSocketHandler;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> Chat()
        {
            return View();
        }

        public async Task Get()
        {
            if (HttpContext.WebSockets.IsWebSocketRequest)
            {
                WebSocket webSocket = await HttpContext.WebSockets.AcceptWebSocketAsync();
                await _webSocketHandler.Handle(Guid.NewGuid(), webSocket);
                //await SendMessages(webSocket);
            }
            else
            {
                HttpContext.Response.StatusCode = 400;
            }
        }

        private async Task SendMessages(WebSocket webSocket)
        {
            int i = 0;
            while (true)
            {
                byte[] message = Encoding.UTF8.GetBytes($"Message {i++}");
                await webSocket.SendAsync(new ArraySegment<byte>(message), WebSocketMessageType.Text, true, CancellationToken.None);
                await Task.Delay(TimeSpan.FromSeconds(5));
            }
        }
    }
}
