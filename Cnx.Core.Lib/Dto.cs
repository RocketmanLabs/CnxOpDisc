using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Cnx.Core.Lib.Interfaces;
using System.Diagnostics;

namespace Cnx.Core.Lib
{
    [DebuggerDisplay("{Info,nq}")]
    public class Dto : Dictionary<String, Object>
    {
        public Guid UserXId { get; set; }
        public Guid InquiryXId { get; set; }
        public Guid AuthToken { get; set; }
        public Guid SessionToken { get; set; }

        public ICnxAction Request { get; set; }

        public string UserMessage { get; set; }
        public string AdminMessage { get; set; }
        public string HttpCode { get; set; }
        public string HttpStatus { get; set; }

        public bool IsError { get; set; }
        public bool OK { get; set; }

        public Dto() { }

        public Dto(ICnxAction request) => this.Request = request;

        public Dto(ICnxAction request, params DtoArg[] args)
        {
            this.Request = request;
            foreach (var arg in args) {
                base.Add(arg.Key, arg.Value);
            }
        }

        public string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);

        public string Info
        {
            get {
                var s = $"Request: {this.Request.Name}";
                if (this.IsError || this.OK) {
                    s += this.IsError ? "[ERROR] " : "";
                    s += this.OK ? "[OK] " : "";
                    s += $"{this.HttpCode} {this.HttpStatus}";
                    s += this.UserMessage.OrFirstContent(this.AdminMessage, this.HttpCode.Space(this.HttpStatus));
                }
                return s;
            }
        }
    }

    public class DtoArg
    { 
        public string Key { get; set; }
        public object Value { get; set; }

        public DtoArg() { }
        public DtoArg(string key, object value) { this.Key = key; this.Value = value; }
    }
}
