//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CooneyCalc
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SimpleObject", Namespace="http://schemas.datacontract.org/2004/07/CooneyCalc_web.Models")]
    public partial class SimpleObject : object
    {
        
        private CooneyCalc.Simple TypeField;
        
        private decimal ValueField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CooneyCalc.Simple Type
        {
            get
            {
                return this.TypeField;
            }
            set
            {
                this.TypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Value
        {
            get
            {
                return this.ValueField;
            }
            set
            {
                this.ValueField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Simple", Namespace="http://schemas.datacontract.org/2004/07/CooneyCalc_web.Models")]
    public enum Simple : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        One = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Two = 1,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SimpleReturn", Namespace="http://schemas.datacontract.org/2004/07/CooneyCalc_web.Models")]
    public partial class SimpleReturn : object
    {
        
        private decimal ValueField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Value
        {
            get
            {
                return this.ValueField;
            }
            set
            {
                this.ValueField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Inputs", Namespace="http://schemas.datacontract.org/2004/07/CooneyCalc_web.Models")]
    public partial class Inputs : object
    {
        
        private double AltitudeField;
        
        private double CFMField;
        
        private double EADBField;
        
        private double EAWBField;
        
        private double EFTField;
        
        private double GPMField;
        
        private double LADBrequiredField;
        
        private double LFTrequiredField;
        
        private double capacityRequiredField;
        
        private int coilsPerBankField;
        
        private int feedsField;
        
        private double finHeightField;
        
        private string finIDField;
        
        private double finLengthField;
        
        private double finThicknessField;
        
        private string fluidNameField;
        
        private double foulingFactorField;
        
        private double fpiField;
        
        private double glycolPercentField;
        
        private bool isHeatingCoilField;
        
        private bool isMaxfpiField;
        
        private bool isStandardCFMField;
        
        private bool isTurbulatorsField;
        
        private double maxPressureDropField;
        
        private double nominalReturnConnSizeField;
        
        private double nominalSupplyConnSizeField;
        
        private int numberConnectionsField;
        
        private int rowsField;
        
        private double tubeThicknessField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Altitude
        {
            get
            {
                return this.AltitudeField;
            }
            set
            {
                this.AltitudeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double CFM
        {
            get
            {
                return this.CFMField;
            }
            set
            {
                this.CFMField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double EADB
        {
            get
            {
                return this.EADBField;
            }
            set
            {
                this.EADBField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double EAWB
        {
            get
            {
                return this.EAWBField;
            }
            set
            {
                this.EAWBField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double EFT
        {
            get
            {
                return this.EFTField;
            }
            set
            {
                this.EFTField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double GPM
        {
            get
            {
                return this.GPMField;
            }
            set
            {
                this.GPMField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double LADBrequired
        {
            get
            {
                return this.LADBrequiredField;
            }
            set
            {
                this.LADBrequiredField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double LFTrequired
        {
            get
            {
                return this.LFTrequiredField;
            }
            set
            {
                this.LFTrequiredField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double capacityRequired
        {
            get
            {
                return this.capacityRequiredField;
            }
            set
            {
                this.capacityRequiredField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int coilsPerBank
        {
            get
            {
                return this.coilsPerBankField;
            }
            set
            {
                this.coilsPerBankField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int feeds
        {
            get
            {
                return this.feedsField;
            }
            set
            {
                this.feedsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double finHeight
        {
            get
            {
                return this.finHeightField;
            }
            set
            {
                this.finHeightField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string finID
        {
            get
            {
                return this.finIDField;
            }
            set
            {
                this.finIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double finLength
        {
            get
            {
                return this.finLengthField;
            }
            set
            {
                this.finLengthField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double finThickness
        {
            get
            {
                return this.finThicknessField;
            }
            set
            {
                this.finThicknessField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string fluidName
        {
            get
            {
                return this.fluidNameField;
            }
            set
            {
                this.fluidNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double foulingFactor
        {
            get
            {
                return this.foulingFactorField;
            }
            set
            {
                this.foulingFactorField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double fpi
        {
            get
            {
                return this.fpiField;
            }
            set
            {
                this.fpiField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double glycolPercent
        {
            get
            {
                return this.glycolPercentField;
            }
            set
            {
                this.glycolPercentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool isHeatingCoil
        {
            get
            {
                return this.isHeatingCoilField;
            }
            set
            {
                this.isHeatingCoilField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool isMaxfpi
        {
            get
            {
                return this.isMaxfpiField;
            }
            set
            {
                this.isMaxfpiField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool isStandardCFM
        {
            get
            {
                return this.isStandardCFMField;
            }
            set
            {
                this.isStandardCFMField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool isTurbulators
        {
            get
            {
                return this.isTurbulatorsField;
            }
            set
            {
                this.isTurbulatorsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double maxPressureDrop
        {
            get
            {
                return this.maxPressureDropField;
            }
            set
            {
                this.maxPressureDropField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double nominalReturnConnSize
        {
            get
            {
                return this.nominalReturnConnSizeField;
            }
            set
            {
                this.nominalReturnConnSizeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double nominalSupplyConnSize
        {
            get
            {
                return this.nominalSupplyConnSizeField;
            }
            set
            {
                this.nominalSupplyConnSizeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int numberConnections
        {
            get
            {
                return this.numberConnectionsField;
            }
            set
            {
                this.numberConnectionsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int rows
        {
            get
            {
                return this.rowsField;
            }
            set
            {
                this.rowsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double tubeThickness
        {
            get
            {
                return this.tubeThicknessField;
            }
            set
            {
                this.tubeThicknessField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Outputs", Namespace="http://schemas.datacontract.org/2004/07/CooneyCalc_web.Models")]
    public partial class Outputs : object
    {
        
        private double APDField;
        
        private int ErrorCodeField;
        
        private string ErrorStringField;
        
        private double FPDField;
        
        private double FaceVelocityField;
        
        private double FluidVelocityField;
        
        private double GPMField;
        
        private double InternalVolumeField;
        
        private double LADBField;
        
        private double LAWBField;
        
        private double LFTField;
        
        private double LatentCapacityField;
        
        private double SCFMField;
        
        private double SensibleCapacityField;
        
        private double TotalcapacityField;
        
        private int WarningCodeField;
        
        private string WarningStringField;
        
        private int feedsField;
        
        private double finThicknessField;
        
        private double fpiField;
        
        private int rowsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double APD
        {
            get
            {
                return this.APDField;
            }
            set
            {
                this.APDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ErrorCode
        {
            get
            {
                return this.ErrorCodeField;
            }
            set
            {
                this.ErrorCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorString
        {
            get
            {
                return this.ErrorStringField;
            }
            set
            {
                this.ErrorStringField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double FPD
        {
            get
            {
                return this.FPDField;
            }
            set
            {
                this.FPDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double FaceVelocity
        {
            get
            {
                return this.FaceVelocityField;
            }
            set
            {
                this.FaceVelocityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double FluidVelocity
        {
            get
            {
                return this.FluidVelocityField;
            }
            set
            {
                this.FluidVelocityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double GPM
        {
            get
            {
                return this.GPMField;
            }
            set
            {
                this.GPMField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double InternalVolume
        {
            get
            {
                return this.InternalVolumeField;
            }
            set
            {
                this.InternalVolumeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double LADB
        {
            get
            {
                return this.LADBField;
            }
            set
            {
                this.LADBField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double LAWB
        {
            get
            {
                return this.LAWBField;
            }
            set
            {
                this.LAWBField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double LFT
        {
            get
            {
                return this.LFTField;
            }
            set
            {
                this.LFTField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double LatentCapacity
        {
            get
            {
                return this.LatentCapacityField;
            }
            set
            {
                this.LatentCapacityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double SCFM
        {
            get
            {
                return this.SCFMField;
            }
            set
            {
                this.SCFMField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double SensibleCapacity
        {
            get
            {
                return this.SensibleCapacityField;
            }
            set
            {
                this.SensibleCapacityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Totalcapacity
        {
            get
            {
                return this.TotalcapacityField;
            }
            set
            {
                this.TotalcapacityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int WarningCode
        {
            get
            {
                return this.WarningCodeField;
            }
            set
            {
                this.WarningCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string WarningString
        {
            get
            {
                return this.WarningStringField;
            }
            set
            {
                this.WarningStringField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int feeds
        {
            get
            {
                return this.feedsField;
            }
            set
            {
                this.feedsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double finThickness
        {
            get
            {
                return this.finThicknessField;
            }
            set
            {
                this.finThicknessField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double fpi
        {
            get
            {
                return this.fpiField;
            }
            set
            {
                this.fpiField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int rows
        {
            get
            {
                return this.rowsField;
            }
            set
            {
                this.rowsField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CooneyCalc.ICooneyCalc")]
    public interface ICooneyCalc
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICooneyCalc/SimpleOperation", ReplyAction="http://tempuri.org/ICooneyCalc/SimpleOperationResponse")]
        System.Threading.Tasks.Task<CooneyCalc.SimpleReturn> SimpleOperationAsync(CooneyCalc.SimpleObject simple);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICooneyCalc/Run", ReplyAction="http://tempuri.org/ICooneyCalc/RunResponse")]
        System.Threading.Tasks.Task<CooneyCalc.Outputs> RunAsync(CooneyCalc.Inputs input);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public interface ICooneyCalcChannel : CooneyCalc.ICooneyCalc, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class CooneyCalcClient : System.ServiceModel.ClientBase<CooneyCalc.ICooneyCalc>, CooneyCalc.ICooneyCalc
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public CooneyCalcClient() : 
                base(CooneyCalcClient.GetDefaultBinding(), CooneyCalcClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_ICooneyCalc.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CooneyCalcClient(EndpointConfiguration endpointConfiguration) : 
                base(CooneyCalcClient.GetBindingForEndpoint(endpointConfiguration), CooneyCalcClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CooneyCalcClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(CooneyCalcClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CooneyCalcClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(CooneyCalcClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CooneyCalcClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<CooneyCalc.SimpleReturn> SimpleOperationAsync(CooneyCalc.SimpleObject simple)
        {
            return base.Channel.SimpleOperationAsync(simple);
        }
        
        public System.Threading.Tasks.Task<CooneyCalc.Outputs> RunAsync(CooneyCalc.Inputs input)
        {
            return base.Channel.RunAsync(input);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ICooneyCalc))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ICooneyCalc))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:16812/CooneyCalc.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return CooneyCalcClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_ICooneyCalc);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return CooneyCalcClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_ICooneyCalc);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_ICooneyCalc,
        }
    }
}
