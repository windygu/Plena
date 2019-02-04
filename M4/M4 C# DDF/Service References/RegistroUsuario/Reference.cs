﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace M4.RegistroUsuario {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RegistroUsuario.RegistroUsuarioSoap")]
    public interface RegistroUsuarioSoap {
        
        // CODEGEN: Generating message contract since element name login from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RegistrarUsuario", ReplyAction="*")]
        M4.RegistroUsuario.RegistrarUsuarioResponse RegistrarUsuario(M4.RegistroUsuario.RegistrarUsuarioRequest request);
        
        // CODEGEN: Generating message contract since element name login from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AtualizarUsuario", ReplyAction="*")]
        M4.RegistroUsuario.AtualizarUsuarioResponse AtualizarUsuario(M4.RegistroUsuario.AtualizarUsuarioRequest request);
        
        // CODEGEN: Generating message contract since element name cpf from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RecuperarUsuario", ReplyAction="*")]
        M4.RegistroUsuario.RecuperarUsuarioResponse RecuperarUsuario(M4.RegistroUsuario.RecuperarUsuarioRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RegistrarUsuarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RegistrarUsuario", Namespace="http://tempuri.org/", Order=0)]
        public M4.RegistroUsuario.RegistrarUsuarioRequestBody Body;
        
        public RegistrarUsuarioRequest() {
        }
        
        public RegistrarUsuarioRequest(M4.RegistroUsuario.RegistrarUsuarioRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class RegistrarUsuarioRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string login;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string senha;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string nome;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string sobrenome;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string cpf;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string email;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string bairro;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string cep;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string cidade;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public string complemento;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=10)]
        public string dataNascimento;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=11)]
        public string estado;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=12)]
        public string lagradouro;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=13)]
        public string numeroResidencia;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=14)]
        public string tipo;
        
        public RegistrarUsuarioRequestBody() {
        }
        
        public RegistrarUsuarioRequestBody(string login, string senha, string nome, string sobrenome, string cpf, string email, string bairro, string cep, string cidade, string complemento, string dataNascimento, string estado, string lagradouro, string numeroResidencia, string tipo) {
            this.login = login;
            this.senha = senha;
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.cpf = cpf;
            this.email = email;
            this.bairro = bairro;
            this.cep = cep;
            this.cidade = cidade;
            this.complemento = complemento;
            this.dataNascimento = dataNascimento;
            this.estado = estado;
            this.lagradouro = lagradouro;
            this.numeroResidencia = numeroResidencia;
            this.tipo = tipo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RegistrarUsuarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RegistrarUsuarioResponse", Namespace="http://tempuri.org/", Order=0)]
        public M4.RegistroUsuario.RegistrarUsuarioResponseBody Body;
        
        public RegistrarUsuarioResponse() {
        }
        
        public RegistrarUsuarioResponse(M4.RegistroUsuario.RegistrarUsuarioResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class RegistrarUsuarioResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement RegistrarUsuarioResult;
        
        public RegistrarUsuarioResponseBody() {
        }
        
        public RegistrarUsuarioResponseBody(System.Xml.Linq.XElement RegistrarUsuarioResult) {
            this.RegistrarUsuarioResult = RegistrarUsuarioResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AtualizarUsuarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AtualizarUsuario", Namespace="http://tempuri.org/", Order=0)]
        public M4.RegistroUsuario.AtualizarUsuarioRequestBody Body;
        
        public AtualizarUsuarioRequest() {
        }
        
        public AtualizarUsuarioRequest(M4.RegistroUsuario.AtualizarUsuarioRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AtualizarUsuarioRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string login;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string senha;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string nome;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string sobrenome;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string cpf;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string email;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string bairro;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string cep;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public string cidade;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=10)]
        public string complemento;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=11)]
        public string dataNascimento;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=12)]
        public string estado;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=13)]
        public string lagradouro;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=14)]
        public string numeroResidencia;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=15)]
        public string tipo;
        
        public AtualizarUsuarioRequestBody() {
        }
        
        public AtualizarUsuarioRequestBody(
                    int id, 
                    string login, 
                    string senha, 
                    string nome, 
                    string sobrenome, 
                    string cpf, 
                    string email, 
                    string bairro, 
                    string cep, 
                    string cidade, 
                    string complemento, 
                    string dataNascimento, 
                    string estado, 
                    string lagradouro, 
                    string numeroResidencia, 
                    string tipo) {
            this.id = id;
            this.login = login;
            this.senha = senha;
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.cpf = cpf;
            this.email = email;
            this.bairro = bairro;
            this.cep = cep;
            this.cidade = cidade;
            this.complemento = complemento;
            this.dataNascimento = dataNascimento;
            this.estado = estado;
            this.lagradouro = lagradouro;
            this.numeroResidencia = numeroResidencia;
            this.tipo = tipo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AtualizarUsuarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AtualizarUsuarioResponse", Namespace="http://tempuri.org/", Order=0)]
        public M4.RegistroUsuario.AtualizarUsuarioResponseBody Body;
        
        public AtualizarUsuarioResponse() {
        }
        
        public AtualizarUsuarioResponse(M4.RegistroUsuario.AtualizarUsuarioResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AtualizarUsuarioResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement AtualizarUsuarioResult;
        
        public AtualizarUsuarioResponseBody() {
        }
        
        public AtualizarUsuarioResponseBody(System.Xml.Linq.XElement AtualizarUsuarioResult) {
            this.AtualizarUsuarioResult = AtualizarUsuarioResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RecuperarUsuarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RecuperarUsuario", Namespace="http://tempuri.org/", Order=0)]
        public M4.RegistroUsuario.RecuperarUsuarioRequestBody Body;
        
        public RecuperarUsuarioRequest() {
        }
        
        public RecuperarUsuarioRequest(M4.RegistroUsuario.RecuperarUsuarioRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class RecuperarUsuarioRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string cpf;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string email;
        
        public RecuperarUsuarioRequestBody() {
        }
        
        public RecuperarUsuarioRequestBody(string cpf, string email) {
            this.cpf = cpf;
            this.email = email;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RecuperarUsuarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RecuperarUsuarioResponse", Namespace="http://tempuri.org/", Order=0)]
        public M4.RegistroUsuario.RecuperarUsuarioResponseBody Body;
        
        public RecuperarUsuarioResponse() {
        }
        
        public RecuperarUsuarioResponse(M4.RegistroUsuario.RecuperarUsuarioResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class RecuperarUsuarioResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement RecuperarUsuarioResult;
        
        public RecuperarUsuarioResponseBody() {
        }
        
        public RecuperarUsuarioResponseBody(System.Xml.Linq.XElement RecuperarUsuarioResult) {
            this.RecuperarUsuarioResult = RecuperarUsuarioResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface RegistroUsuarioSoapChannel : M4.RegistroUsuario.RegistroUsuarioSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RegistroUsuarioSoapClient : System.ServiceModel.ClientBase<M4.RegistroUsuario.RegistroUsuarioSoap>, M4.RegistroUsuario.RegistroUsuarioSoap {
        
        public RegistroUsuarioSoapClient() {
        }
        
        public RegistroUsuarioSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RegistroUsuarioSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RegistroUsuarioSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RegistroUsuarioSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        M4.RegistroUsuario.RegistrarUsuarioResponse M4.RegistroUsuario.RegistroUsuarioSoap.RegistrarUsuario(M4.RegistroUsuario.RegistrarUsuarioRequest request) {
            return base.Channel.RegistrarUsuario(request);
        }
        
        public System.Xml.Linq.XElement RegistrarUsuario(string login, string senha, string nome, string sobrenome, string cpf, string email, string bairro, string cep, string cidade, string complemento, string dataNascimento, string estado, string lagradouro, string numeroResidencia, string tipo) {
            M4.RegistroUsuario.RegistrarUsuarioRequest inValue = new M4.RegistroUsuario.RegistrarUsuarioRequest();
            inValue.Body = new M4.RegistroUsuario.RegistrarUsuarioRequestBody();
            inValue.Body.login = login;
            inValue.Body.senha = senha;
            inValue.Body.nome = nome;
            inValue.Body.sobrenome = sobrenome;
            inValue.Body.cpf = cpf;
            inValue.Body.email = email;
            inValue.Body.bairro = bairro;
            inValue.Body.cep = cep;
            inValue.Body.cidade = cidade;
            inValue.Body.complemento = complemento;
            inValue.Body.dataNascimento = dataNascimento;
            inValue.Body.estado = estado;
            inValue.Body.lagradouro = lagradouro;
            inValue.Body.numeroResidencia = numeroResidencia;
            inValue.Body.tipo = tipo;
            M4.RegistroUsuario.RegistrarUsuarioResponse retVal = ((M4.RegistroUsuario.RegistroUsuarioSoap)(this)).RegistrarUsuario(inValue);
            return retVal.Body.RegistrarUsuarioResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        M4.RegistroUsuario.AtualizarUsuarioResponse M4.RegistroUsuario.RegistroUsuarioSoap.AtualizarUsuario(M4.RegistroUsuario.AtualizarUsuarioRequest request) {
            return base.Channel.AtualizarUsuario(request);
        }
        
        public System.Xml.Linq.XElement AtualizarUsuario(
                    int id, 
                    string login, 
                    string senha, 
                    string nome, 
                    string sobrenome, 
                    string cpf, 
                    string email, 
                    string bairro, 
                    string cep, 
                    string cidade, 
                    string complemento, 
                    string dataNascimento, 
                    string estado, 
                    string lagradouro, 
                    string numeroResidencia, 
                    string tipo) {
            M4.RegistroUsuario.AtualizarUsuarioRequest inValue = new M4.RegistroUsuario.AtualizarUsuarioRequest();
            inValue.Body = new M4.RegistroUsuario.AtualizarUsuarioRequestBody();
            inValue.Body.id = id;
            inValue.Body.login = login;
            inValue.Body.senha = senha;
            inValue.Body.nome = nome;
            inValue.Body.sobrenome = sobrenome;
            inValue.Body.cpf = cpf;
            inValue.Body.email = email;
            inValue.Body.bairro = bairro;
            inValue.Body.cep = cep;
            inValue.Body.cidade = cidade;
            inValue.Body.complemento = complemento;
            inValue.Body.dataNascimento = dataNascimento;
            inValue.Body.estado = estado;
            inValue.Body.lagradouro = lagradouro;
            inValue.Body.numeroResidencia = numeroResidencia;
            inValue.Body.tipo = tipo;
            M4.RegistroUsuario.AtualizarUsuarioResponse retVal = ((M4.RegistroUsuario.RegistroUsuarioSoap)(this)).AtualizarUsuario(inValue);
            return retVal.Body.AtualizarUsuarioResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        M4.RegistroUsuario.RecuperarUsuarioResponse M4.RegistroUsuario.RegistroUsuarioSoap.RecuperarUsuario(M4.RegistroUsuario.RecuperarUsuarioRequest request) {
            return base.Channel.RecuperarUsuario(request);
        }
        
        public System.Xml.Linq.XElement RecuperarUsuario(string cpf, string email) {
            M4.RegistroUsuario.RecuperarUsuarioRequest inValue = new M4.RegistroUsuario.RecuperarUsuarioRequest();
            inValue.Body = new M4.RegistroUsuario.RecuperarUsuarioRequestBody();
            inValue.Body.cpf = cpf;
            inValue.Body.email = email;
            M4.RegistroUsuario.RecuperarUsuarioResponse retVal = ((M4.RegistroUsuario.RegistroUsuarioSoap)(this)).RecuperarUsuario(inValue);
            return retVal.Body.RecuperarUsuarioResult;
        }
    }
}