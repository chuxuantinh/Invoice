﻿using Microsoft.AspNetCore.Http;

namespace InvoiceWebApp {

    public class RequestContextManager {
        public static RequestContextManager Instance { get; set; }

        static RequestContextManager() {
            Instance = new RequestContextManager(null);
        }

        private readonly IHttpContextAccessor contextAccessor;

        public RequestContextManager(IHttpContextAccessor contextAccessor) {
            this.contextAccessor = contextAccessor;
        }

        public HttpContext CurrentContext {
            get {
                if (contextAccessor == null)
                    return null;
                return contextAccessor.HttpContext;
            }
        }
    }
}