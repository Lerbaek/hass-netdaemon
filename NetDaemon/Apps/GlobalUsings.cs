// Common usings for NetDaemon apps
global using System;
global using System.Collections.Concurrent;
global using System.Collections.Generic;
global using System.Globalization;
global using System.IO;
global using System.IO.Abstractions;
global using System.Linq;
global using System.Net.Http;
global using System.Reactive.Linq;
global using System.Reflection;
global using System.Threading;
global using System.Threading.Tasks;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Hosting;
global using Microsoft.Extensions.Logging;
global using HomeAssistantGenerated;
global using NetDaemon.AppModel;
global using NetDaemon.Client;
global using NetDaemon.Client.HomeAssistant.Extensions;
global using NetDaemon.Extensions.Logging;
global using NetDaemon.Extensions.Scheduler;
global using NetDaemon.Extensions.Tts;
global using NetDaemon.HassModel;
global using NetDaemon.HassModel.Entities;
global using NetDaemon.HassModel.Integration;
global using NetDaemon.Runtime;
global using Newtonsoft.Json;
global using Newtonsoft.Json.Linq;
global using Polly;
global using Polly.Contrib.WaitAndRetry;
global using static System.Drawing.Color;
global using static System.Environment;
global using static System.Net.HttpStatusCode;
global using static System.TimeSpan;
global using static Polly.Extensions.Http.HttpPolicyExtensions;
global using Lerbaek.NetDaemon.Common.Notifications;
global using System.Drawing;