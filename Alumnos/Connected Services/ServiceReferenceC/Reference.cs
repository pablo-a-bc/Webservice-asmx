﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Negocio.ServiceReferenceC {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ECarrera", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class ECarrera : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string carreraField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AreadenegocioField;
        
        private bool EstadoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoField, value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string carrera {
            get {
                return this.carreraField;
            }
            set {
                if ((object.ReferenceEquals(this.carreraField, value) != true)) {
                    this.carreraField = value;
                    this.RaisePropertyChanged("carrera");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Areadenegocio {
            get {
                return this.AreadenegocioField;
            }
            set {
                if ((object.ReferenceEquals(this.AreadenegocioField, value) != true)) {
                    this.AreadenegocioField = value;
                    this.RaisePropertyChanged("Areadenegocio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public bool Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((this.EstadoField.Equals(value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceC.WebServiceCarreraSoap")]
    public interface WebServiceCarreraSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento eCarrera del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Crear", ReplyAction="*")]
        Negocio.ServiceReferenceC.CrearResponse Crear(Negocio.ServiceReferenceC.CrearRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Crear", ReplyAction="*")]
        System.Threading.Tasks.Task<Negocio.ServiceReferenceC.CrearResponse> CrearAsync(Negocio.ServiceReferenceC.CrearRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento cod del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BuscarCod", ReplyAction="*")]
        Negocio.ServiceReferenceC.BuscarCodResponse BuscarCod(Negocio.ServiceReferenceC.BuscarCodRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BuscarCod", ReplyAction="*")]
        System.Threading.Tasks.Task<Negocio.ServiceReferenceC.BuscarCodResponse> BuscarCodAsync(Negocio.ServiceReferenceC.BuscarCodRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento BuscarIdResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BuscarId", ReplyAction="*")]
        Negocio.ServiceReferenceC.BuscarIdResponse BuscarId(Negocio.ServiceReferenceC.BuscarIdRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BuscarId", ReplyAction="*")]
        System.Threading.Tasks.Task<Negocio.ServiceReferenceC.BuscarIdResponse> BuscarIdAsync(Negocio.ServiceReferenceC.BuscarIdRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento eCarrera del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Actualizar", ReplyAction="*")]
        Negocio.ServiceReferenceC.ActualizarResponse Actualizar(Negocio.ServiceReferenceC.ActualizarRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Actualizar", ReplyAction="*")]
        System.Threading.Tasks.Task<Negocio.ServiceReferenceC.ActualizarResponse> ActualizarAsync(Negocio.ServiceReferenceC.ActualizarRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Eliminar", ReplyAction="*")]
        bool Eliminar(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Eliminar", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> EliminarAsync(int id);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento MostrarResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Mostrar", ReplyAction="*")]
        Negocio.ServiceReferenceC.MostrarResponse Mostrar(Negocio.ServiceReferenceC.MostrarRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Mostrar", ReplyAction="*")]
        System.Threading.Tasks.Task<Negocio.ServiceReferenceC.MostrarResponse> MostrarAsync(Negocio.ServiceReferenceC.MostrarRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CrearRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Crear", Namespace="http://tempuri.org/", Order=0)]
        public Negocio.ServiceReferenceC.CrearRequestBody Body;
        
        public CrearRequest() {
        }
        
        public CrearRequest(Negocio.ServiceReferenceC.CrearRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CrearRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Negocio.ServiceReferenceC.ECarrera eCarrera;
        
        public CrearRequestBody() {
        }
        
        public CrearRequestBody(Negocio.ServiceReferenceC.ECarrera eCarrera) {
            this.eCarrera = eCarrera;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CrearResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CrearResponse", Namespace="http://tempuri.org/", Order=0)]
        public Negocio.ServiceReferenceC.CrearResponseBody Body;
        
        public CrearResponse() {
        }
        
        public CrearResponse(Negocio.ServiceReferenceC.CrearResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class CrearResponseBody {
        
        public CrearResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class BuscarCodRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="BuscarCod", Namespace="http://tempuri.org/", Order=0)]
        public Negocio.ServiceReferenceC.BuscarCodRequestBody Body;
        
        public BuscarCodRequest() {
        }
        
        public BuscarCodRequest(Negocio.ServiceReferenceC.BuscarCodRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class BuscarCodRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string cod;
        
        public BuscarCodRequestBody() {
        }
        
        public BuscarCodRequestBody(string cod) {
            this.cod = cod;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class BuscarCodResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="BuscarCodResponse", Namespace="http://tempuri.org/", Order=0)]
        public Negocio.ServiceReferenceC.BuscarCodResponseBody Body;
        
        public BuscarCodResponse() {
        }
        
        public BuscarCodResponse(Negocio.ServiceReferenceC.BuscarCodResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class BuscarCodResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Negocio.ServiceReferenceC.ECarrera BuscarCodResult;
        
        public BuscarCodResponseBody() {
        }
        
        public BuscarCodResponseBody(Negocio.ServiceReferenceC.ECarrera BuscarCodResult) {
            this.BuscarCodResult = BuscarCodResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class BuscarIdRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="BuscarId", Namespace="http://tempuri.org/", Order=0)]
        public Negocio.ServiceReferenceC.BuscarIdRequestBody Body;
        
        public BuscarIdRequest() {
        }
        
        public BuscarIdRequest(Negocio.ServiceReferenceC.BuscarIdRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class BuscarIdRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int Id;
        
        public BuscarIdRequestBody() {
        }
        
        public BuscarIdRequestBody(int Id) {
            this.Id = Id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class BuscarIdResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="BuscarIdResponse", Namespace="http://tempuri.org/", Order=0)]
        public Negocio.ServiceReferenceC.BuscarIdResponseBody Body;
        
        public BuscarIdResponse() {
        }
        
        public BuscarIdResponse(Negocio.ServiceReferenceC.BuscarIdResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class BuscarIdResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Negocio.ServiceReferenceC.ECarrera BuscarIdResult;
        
        public BuscarIdResponseBody() {
        }
        
        public BuscarIdResponseBody(Negocio.ServiceReferenceC.ECarrera BuscarIdResult) {
            this.BuscarIdResult = BuscarIdResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ActualizarRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Actualizar", Namespace="http://tempuri.org/", Order=0)]
        public Negocio.ServiceReferenceC.ActualizarRequestBody Body;
        
        public ActualizarRequest() {
        }
        
        public ActualizarRequest(Negocio.ServiceReferenceC.ActualizarRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ActualizarRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Negocio.ServiceReferenceC.ECarrera eCarrera;
        
        public ActualizarRequestBody() {
        }
        
        public ActualizarRequestBody(Negocio.ServiceReferenceC.ECarrera eCarrera) {
            this.eCarrera = eCarrera;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ActualizarResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ActualizarResponse", Namespace="http://tempuri.org/", Order=0)]
        public Negocio.ServiceReferenceC.ActualizarResponseBody Body;
        
        public ActualizarResponse() {
        }
        
        public ActualizarResponse(Negocio.ServiceReferenceC.ActualizarResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ActualizarResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool ActualizarResult;
        
        public ActualizarResponseBody() {
        }
        
        public ActualizarResponseBody(bool ActualizarResult) {
            this.ActualizarResult = ActualizarResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class MostrarRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Mostrar", Namespace="http://tempuri.org/", Order=0)]
        public Negocio.ServiceReferenceC.MostrarRequestBody Body;
        
        public MostrarRequest() {
        }
        
        public MostrarRequest(Negocio.ServiceReferenceC.MostrarRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class MostrarRequestBody {
        
        public MostrarRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class MostrarResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="MostrarResponse", Namespace="http://tempuri.org/", Order=0)]
        public Negocio.ServiceReferenceC.MostrarResponseBody Body;
        
        public MostrarResponse() {
        }
        
        public MostrarResponse(Negocio.ServiceReferenceC.MostrarResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class MostrarResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Negocio.ServiceReferenceC.ECarrera[] MostrarResult;
        
        public MostrarResponseBody() {
        }
        
        public MostrarResponseBody(Negocio.ServiceReferenceC.ECarrera[] MostrarResult) {
            this.MostrarResult = MostrarResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceCarreraSoapChannel : Negocio.ServiceReferenceC.WebServiceCarreraSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceCarreraSoapClient : System.ServiceModel.ClientBase<Negocio.ServiceReferenceC.WebServiceCarreraSoap>, Negocio.ServiceReferenceC.WebServiceCarreraSoap {
        
        public WebServiceCarreraSoapClient() {
        }
        
        public WebServiceCarreraSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceCarreraSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceCarreraSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceCarreraSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Negocio.ServiceReferenceC.CrearResponse Negocio.ServiceReferenceC.WebServiceCarreraSoap.Crear(Negocio.ServiceReferenceC.CrearRequest request) {
            return base.Channel.Crear(request);
        }
        
        public void Crear(Negocio.ServiceReferenceC.ECarrera eCarrera) {
            Negocio.ServiceReferenceC.CrearRequest inValue = new Negocio.ServiceReferenceC.CrearRequest();
            inValue.Body = new Negocio.ServiceReferenceC.CrearRequestBody();
            inValue.Body.eCarrera = eCarrera;
            Negocio.ServiceReferenceC.CrearResponse retVal = ((Negocio.ServiceReferenceC.WebServiceCarreraSoap)(this)).Crear(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Negocio.ServiceReferenceC.CrearResponse> Negocio.ServiceReferenceC.WebServiceCarreraSoap.CrearAsync(Negocio.ServiceReferenceC.CrearRequest request) {
            return base.Channel.CrearAsync(request);
        }
        
        public System.Threading.Tasks.Task<Negocio.ServiceReferenceC.CrearResponse> CrearAsync(Negocio.ServiceReferenceC.ECarrera eCarrera) {
            Negocio.ServiceReferenceC.CrearRequest inValue = new Negocio.ServiceReferenceC.CrearRequest();
            inValue.Body = new Negocio.ServiceReferenceC.CrearRequestBody();
            inValue.Body.eCarrera = eCarrera;
            return ((Negocio.ServiceReferenceC.WebServiceCarreraSoap)(this)).CrearAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Negocio.ServiceReferenceC.BuscarCodResponse Negocio.ServiceReferenceC.WebServiceCarreraSoap.BuscarCod(Negocio.ServiceReferenceC.BuscarCodRequest request) {
            return base.Channel.BuscarCod(request);
        }
        
        public Negocio.ServiceReferenceC.ECarrera BuscarCod(string cod) {
            Negocio.ServiceReferenceC.BuscarCodRequest inValue = new Negocio.ServiceReferenceC.BuscarCodRequest();
            inValue.Body = new Negocio.ServiceReferenceC.BuscarCodRequestBody();
            inValue.Body.cod = cod;
            Negocio.ServiceReferenceC.BuscarCodResponse retVal = ((Negocio.ServiceReferenceC.WebServiceCarreraSoap)(this)).BuscarCod(inValue);
            return retVal.Body.BuscarCodResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Negocio.ServiceReferenceC.BuscarCodResponse> Negocio.ServiceReferenceC.WebServiceCarreraSoap.BuscarCodAsync(Negocio.ServiceReferenceC.BuscarCodRequest request) {
            return base.Channel.BuscarCodAsync(request);
        }
        
        public System.Threading.Tasks.Task<Negocio.ServiceReferenceC.BuscarCodResponse> BuscarCodAsync(string cod) {
            Negocio.ServiceReferenceC.BuscarCodRequest inValue = new Negocio.ServiceReferenceC.BuscarCodRequest();
            inValue.Body = new Negocio.ServiceReferenceC.BuscarCodRequestBody();
            inValue.Body.cod = cod;
            return ((Negocio.ServiceReferenceC.WebServiceCarreraSoap)(this)).BuscarCodAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Negocio.ServiceReferenceC.BuscarIdResponse Negocio.ServiceReferenceC.WebServiceCarreraSoap.BuscarId(Negocio.ServiceReferenceC.BuscarIdRequest request) {
            return base.Channel.BuscarId(request);
        }
        
        public Negocio.ServiceReferenceC.ECarrera BuscarId(int Id) {
            Negocio.ServiceReferenceC.BuscarIdRequest inValue = new Negocio.ServiceReferenceC.BuscarIdRequest();
            inValue.Body = new Negocio.ServiceReferenceC.BuscarIdRequestBody();
            inValue.Body.Id = Id;
            Negocio.ServiceReferenceC.BuscarIdResponse retVal = ((Negocio.ServiceReferenceC.WebServiceCarreraSoap)(this)).BuscarId(inValue);
            return retVal.Body.BuscarIdResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Negocio.ServiceReferenceC.BuscarIdResponse> Negocio.ServiceReferenceC.WebServiceCarreraSoap.BuscarIdAsync(Negocio.ServiceReferenceC.BuscarIdRequest request) {
            return base.Channel.BuscarIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<Negocio.ServiceReferenceC.BuscarIdResponse> BuscarIdAsync(int Id) {
            Negocio.ServiceReferenceC.BuscarIdRequest inValue = new Negocio.ServiceReferenceC.BuscarIdRequest();
            inValue.Body = new Negocio.ServiceReferenceC.BuscarIdRequestBody();
            inValue.Body.Id = Id;
            return ((Negocio.ServiceReferenceC.WebServiceCarreraSoap)(this)).BuscarIdAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Negocio.ServiceReferenceC.ActualizarResponse Negocio.ServiceReferenceC.WebServiceCarreraSoap.Actualizar(Negocio.ServiceReferenceC.ActualizarRequest request) {
            return base.Channel.Actualizar(request);
        }
        
        public bool Actualizar(Negocio.ServiceReferenceC.ECarrera eCarrera) {
            Negocio.ServiceReferenceC.ActualizarRequest inValue = new Negocio.ServiceReferenceC.ActualizarRequest();
            inValue.Body = new Negocio.ServiceReferenceC.ActualizarRequestBody();
            inValue.Body.eCarrera = eCarrera;
            Negocio.ServiceReferenceC.ActualizarResponse retVal = ((Negocio.ServiceReferenceC.WebServiceCarreraSoap)(this)).Actualizar(inValue);
            return retVal.Body.ActualizarResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Negocio.ServiceReferenceC.ActualizarResponse> Negocio.ServiceReferenceC.WebServiceCarreraSoap.ActualizarAsync(Negocio.ServiceReferenceC.ActualizarRequest request) {
            return base.Channel.ActualizarAsync(request);
        }
        
        public System.Threading.Tasks.Task<Negocio.ServiceReferenceC.ActualizarResponse> ActualizarAsync(Negocio.ServiceReferenceC.ECarrera eCarrera) {
            Negocio.ServiceReferenceC.ActualizarRequest inValue = new Negocio.ServiceReferenceC.ActualizarRequest();
            inValue.Body = new Negocio.ServiceReferenceC.ActualizarRequestBody();
            inValue.Body.eCarrera = eCarrera;
            return ((Negocio.ServiceReferenceC.WebServiceCarreraSoap)(this)).ActualizarAsync(inValue);
        }
        
        public bool Eliminar(int id) {
            return base.Channel.Eliminar(id);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarAsync(int id) {
            return base.Channel.EliminarAsync(id);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Negocio.ServiceReferenceC.MostrarResponse Negocio.ServiceReferenceC.WebServiceCarreraSoap.Mostrar(Negocio.ServiceReferenceC.MostrarRequest request) {
            return base.Channel.Mostrar(request);
        }
        
        public Negocio.ServiceReferenceC.ECarrera[] Mostrar() {
            Negocio.ServiceReferenceC.MostrarRequest inValue = new Negocio.ServiceReferenceC.MostrarRequest();
            inValue.Body = new Negocio.ServiceReferenceC.MostrarRequestBody();
            Negocio.ServiceReferenceC.MostrarResponse retVal = ((Negocio.ServiceReferenceC.WebServiceCarreraSoap)(this)).Mostrar(inValue);
            return retVal.Body.MostrarResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Negocio.ServiceReferenceC.MostrarResponse> Negocio.ServiceReferenceC.WebServiceCarreraSoap.MostrarAsync(Negocio.ServiceReferenceC.MostrarRequest request) {
            return base.Channel.MostrarAsync(request);
        }
        
        public System.Threading.Tasks.Task<Negocio.ServiceReferenceC.MostrarResponse> MostrarAsync() {
            Negocio.ServiceReferenceC.MostrarRequest inValue = new Negocio.ServiceReferenceC.MostrarRequest();
            inValue.Body = new Negocio.ServiceReferenceC.MostrarRequestBody();
            return ((Negocio.ServiceReferenceC.WebServiceCarreraSoap)(this)).MostrarAsync(inValue);
        }
    }
}
