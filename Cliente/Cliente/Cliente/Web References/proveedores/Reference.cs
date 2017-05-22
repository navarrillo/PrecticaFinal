﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace Cliente.proveedores {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="proveedor2SOAP", Namespace="http://www.example.org/proveedor2/")]
    public partial class proveedor2SOAP : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback solicitarPresupuestoOperationCompleted;
        
        private System.Threading.SendOrPostCallback solicitarPersonalizadoOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public proveedor2SOAP() {
            this.Url = global::Cliente.Properties.Settings.Default.Cliente_proveedores_proveedor2;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event solicitarPresupuestoCompletedEventHandler solicitarPresupuestoCompleted;
        
        /// <remarks/>
        public event solicitarPersonalizadoCompletedEventHandler solicitarPersonalizadoCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.example.org/proveedor2/solicitarPresupuesto", RequestNamespace="http://www.example.org/proveedor2/", ResponseNamespace="http://www.example.org/proveedor2/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("salida", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double solicitarPresupuesto([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] int unidades) {
            object[] results = this.Invoke("solicitarPresupuesto", new object[] {
                        unidades});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void solicitarPresupuestoAsync(int unidades) {
            this.solicitarPresupuestoAsync(unidades, null);
        }
        
        /// <remarks/>
        public void solicitarPresupuestoAsync(int unidades, object userState) {
            if ((this.solicitarPresupuestoOperationCompleted == null)) {
                this.solicitarPresupuestoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsolicitarPresupuestoOperationCompleted);
            }
            this.InvokeAsync("solicitarPresupuesto", new object[] {
                        unidades}, this.solicitarPresupuestoOperationCompleted, userState);
        }
        
        private void OnsolicitarPresupuestoOperationCompleted(object arg) {
            if ((this.solicitarPresupuestoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.solicitarPresupuestoCompleted(this, new solicitarPresupuestoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.example.org/proveedor2/solicitarPersonalizado", RequestNamespace="http://www.example.org/proveedor2/", ResponseNamespace="http://www.example.org/proveedor2/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("salida", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double solicitarPersonalizado([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] bool ski, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] bool material, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] bool profesor, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] bool alojamiento, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] int unidades) {
            object[] results = this.Invoke("solicitarPersonalizado", new object[] {
                        ski,
                        material,
                        profesor,
                        alojamiento,
                        unidades});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void solicitarPersonalizadoAsync(bool ski, bool material, bool profesor, bool alojamiento, int unidades) {
            this.solicitarPersonalizadoAsync(ski, material, profesor, alojamiento, unidades, null);
        }
        
        /// <remarks/>
        public void solicitarPersonalizadoAsync(bool ski, bool material, bool profesor, bool alojamiento, int unidades, object userState) {
            if ((this.solicitarPersonalizadoOperationCompleted == null)) {
                this.solicitarPersonalizadoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsolicitarPersonalizadoOperationCompleted);
            }
            this.InvokeAsync("solicitarPersonalizado", new object[] {
                        ski,
                        material,
                        profesor,
                        alojamiento,
                        unidades}, this.solicitarPersonalizadoOperationCompleted, userState);
        }
        
        private void OnsolicitarPersonalizadoOperationCompleted(object arg) {
            if ((this.solicitarPersonalizadoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.solicitarPersonalizadoCompleted(this, new solicitarPersonalizadoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="proveedor1SOAP", Namespace="http://www.example.org/proveedor1/")]
    public partial class proveedor1SOAP : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback solicitarPresupuestoOperationCompleted;
        
        private System.Threading.SendOrPostCallback solicitarPersonalizadoOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public proveedor1SOAP() {
            this.Url = global::Cliente.Properties.Settings.Default.Cliente_proveedores_proveedor1;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event solicitarPresupuestoCompletedEventHandler solicitarPresupuestoCompleted;
        
        /// <remarks/>
        public event solicitarPersonalizadoCompletedEventHandler solicitarPersonalizadoCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.example.org/proveedor1/solicitarPresupuesto", RequestNamespace="http://www.example.org/proveedor1/", ResponseNamespace="http://www.example.org/proveedor1/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("salida", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double solicitarPresupuesto([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] int unidades) {
            object[] results = this.Invoke("solicitarPresupuesto", new object[] {
                        unidades});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void solicitarPresupuestoAsync(int unidades) {
            this.solicitarPresupuestoAsync(unidades, null);
        }
        
        /// <remarks/>
        public void solicitarPresupuestoAsync(int unidades, object userState) {
            if ((this.solicitarPresupuestoOperationCompleted == null)) {
                this.solicitarPresupuestoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsolicitarPresupuestoOperationCompleted);
            }
            this.InvokeAsync("solicitarPresupuesto", new object[] {
                        unidades}, this.solicitarPresupuestoOperationCompleted, userState);
        }
        
        private void OnsolicitarPresupuestoOperationCompleted(object arg) {
            if ((this.solicitarPresupuestoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.solicitarPresupuestoCompleted(this, new solicitarPresupuestoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.example.org/proveedor1/solicitarPersonalizado", RequestNamespace="http://www.example.org/proveedor1/", ResponseNamespace="http://www.example.org/proveedor1/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("salida", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double solicitarPersonalizado([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] bool ski, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] bool material, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] bool profesor, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] bool alojamiento, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] int unidades) {
            object[] results = this.Invoke("solicitarPersonalizado", new object[] {
                        ski,
                        material,
                        profesor,
                        alojamiento,
                        unidades});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void solicitarPersonalizadoAsync(bool ski, bool material, bool profesor, bool alojamiento, int unidades) {
            this.solicitarPersonalizadoAsync(ski, material, profesor, alojamiento, unidades, null);
        }
        
        /// <remarks/>
        public void solicitarPersonalizadoAsync(bool ski, bool material, bool profesor, bool alojamiento, int unidades, object userState) {
            if ((this.solicitarPersonalizadoOperationCompleted == null)) {
                this.solicitarPersonalizadoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsolicitarPersonalizadoOperationCompleted);
            }
            this.InvokeAsync("solicitarPersonalizado", new object[] {
                        ski,
                        material,
                        profesor,
                        alojamiento,
                        unidades}, this.solicitarPersonalizadoOperationCompleted, userState);
        }
        
        private void OnsolicitarPersonalizadoOperationCompleted(object arg) {
            if ((this.solicitarPersonalizadoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.solicitarPersonalizadoCompleted(this, new solicitarPersonalizadoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="proveedor3SOAP", Namespace="http://www.example.org/proveedor3/")]
    public partial class proveedor3SOAP : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback solicitarPresupuestoOperationCompleted;
        
        private System.Threading.SendOrPostCallback solicitarPersonalizadoOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public proveedor3SOAP() {
            this.Url = global::Cliente.Properties.Settings.Default.Cliente_proveedores_proveedor3;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event solicitarPresupuestoCompletedEventHandler solicitarPresupuestoCompleted;
        
        /// <remarks/>
        public event solicitarPersonalizadoCompletedEventHandler solicitarPersonalizadoCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.example.org/proveedor3/solicitarPresupuesto", RequestNamespace="http://www.example.org/proveedor3/", ResponseNamespace="http://www.example.org/proveedor3/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("salida", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double solicitarPresupuesto([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] int unidades) {
            object[] results = this.Invoke("solicitarPresupuesto", new object[] {
                        unidades});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void solicitarPresupuestoAsync(int unidades) {
            this.solicitarPresupuestoAsync(unidades, null);
        }
        
        /// <remarks/>
        public void solicitarPresupuestoAsync(int unidades, object userState) {
            if ((this.solicitarPresupuestoOperationCompleted == null)) {
                this.solicitarPresupuestoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsolicitarPresupuestoOperationCompleted);
            }
            this.InvokeAsync("solicitarPresupuesto", new object[] {
                        unidades}, this.solicitarPresupuestoOperationCompleted, userState);
        }
        
        private void OnsolicitarPresupuestoOperationCompleted(object arg) {
            if ((this.solicitarPresupuestoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.solicitarPresupuestoCompleted(this, new solicitarPresupuestoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.example.org/proveedor3/solicitarPersonalizado", RequestNamespace="http://www.example.org/proveedor3/", ResponseNamespace="http://www.example.org/proveedor3/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("salida", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double solicitarPersonalizado([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] bool ski, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] bool material, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] bool profesor, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] bool alojamiento, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] int unidades) {
            object[] results = this.Invoke("solicitarPersonalizado", new object[] {
                        ski,
                        material,
                        profesor,
                        alojamiento,
                        unidades});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void solicitarPersonalizadoAsync(bool ski, bool material, bool profesor, bool alojamiento, int unidades) {
            this.solicitarPersonalizadoAsync(ski, material, profesor, alojamiento, unidades, null);
        }
        
        /// <remarks/>
        public void solicitarPersonalizadoAsync(bool ski, bool material, bool profesor, bool alojamiento, int unidades, object userState) {
            if ((this.solicitarPersonalizadoOperationCompleted == null)) {
                this.solicitarPersonalizadoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsolicitarPersonalizadoOperationCompleted);
            }
            this.InvokeAsync("solicitarPersonalizado", new object[] {
                        ski,
                        material,
                        profesor,
                        alojamiento,
                        unidades}, this.solicitarPersonalizadoOperationCompleted, userState);
        }
        
        private void OnsolicitarPersonalizadoOperationCompleted(object arg) {
            if ((this.solicitarPersonalizadoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.solicitarPersonalizadoCompleted(this, new solicitarPersonalizadoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ReservaPersBinding", Namespace="http://proyectoFinal")]
    public partial class ReservaPersBinding : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback processOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ReservaPersBinding() {
            this.Url = global::Cliente.Properties.Settings.Default.Cliente_proveedores_ReservaPersService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event processCompletedEventHandler processCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://proyectoFinal/process", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("ReservaPersResponse", Namespace="http://proyectoFinal")]
        public ReservaPersResponse process([System.Xml.Serialization.XmlElementAttribute(Namespace="http://proyectoFinal")] ReservaPersRequest ReservaPersRequest) {
            object[] results = this.Invoke("process", new object[] {
                        ReservaPersRequest});
            return ((ReservaPersResponse)(results[0]));
        }
        
        /// <remarks/>
        public void processAsync(ReservaPersRequest ReservaPersRequest) {
            this.processAsync(ReservaPersRequest, null);
        }
        
        /// <remarks/>
        public void processAsync(ReservaPersRequest ReservaPersRequest, object userState) {
            if ((this.processOperationCompleted == null)) {
                this.processOperationCompleted = new System.Threading.SendOrPostCallback(this.OnprocessOperationCompleted);
            }
            this.InvokeAsync("process", new object[] {
                        ReservaPersRequest}, this.processOperationCompleted, userState);
        }
        
        private void OnprocessOperationCompleted(object arg) {
            if ((this.processCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.processCompleted(this, new processCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://proyectoFinal")]
    public partial class ReservaPersRequest {
        
        private bool skiField;
        
        private bool materialField;
        
        private bool profesorField;
        
        private bool alojamientoField;
        
        private int unidadesField;
        
        /// <remarks/>
        public bool ski {
            get {
                return this.skiField;
            }
            set {
                this.skiField = value;
            }
        }
        
        /// <remarks/>
        public bool material {
            get {
                return this.materialField;
            }
            set {
                this.materialField = value;
            }
        }
        
        /// <remarks/>
        public bool profesor {
            get {
                return this.profesorField;
            }
            set {
                this.profesorField = value;
            }
        }
        
        /// <remarks/>
        public bool alojamiento {
            get {
                return this.alojamientoField;
            }
            set {
                this.alojamientoField = value;
            }
        }
        
        /// <remarks/>
        public int unidades {
            get {
                return this.unidadesField;
            }
            set {
                this.unidadesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://proyectoFinal")]
    public partial class ReservaPersResponse {
        
        private double precioField;
        
        private string proveedorField;
        
        /// <remarks/>
        public double precio {
            get {
                return this.precioField;
            }
            set {
                this.precioField = value;
            }
        }
        
        /// <remarks/>
        public string proveedor {
            get {
                return this.proveedorField;
            }
            set {
                this.proveedorField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void solicitarPresupuestoCompletedEventHandler(object sender, solicitarPresupuestoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class solicitarPresupuestoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal solicitarPresupuestoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void solicitarPersonalizadoCompletedEventHandler(object sender, solicitarPersonalizadoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class solicitarPersonalizadoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal solicitarPersonalizadoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void processCompletedEventHandler(object sender, processCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class processCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal processCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ReservaPersResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ReservaPersResponse)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591