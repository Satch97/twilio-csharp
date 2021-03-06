/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Studio.V1.Flow
{

    /// <summary>
    /// Retrieve a list of all Engagements for the Flow.
    /// </summary>
    public class ReadEngagementOptions : ReadOptions<EngagementResource>
    {
        /// <summary>
        /// The SID of the Flow to read Engagements from
        /// </summary>
        public string PathFlowSid { get; }

        /// <summary>
        /// Construct a new ReadEngagementOptions
        /// </summary>
        /// <param name="pathFlowSid"> The SID of the Flow to read Engagements from </param>
        public ReadEngagementOptions(string pathFlowSid)
        {
            PathFlowSid = pathFlowSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// Retrieve an Engagement
    /// </summary>
    public class FetchEngagementOptions : IOptions<EngagementResource>
    {
        /// <summary>
        /// Flow SID
        /// </summary>
        public string PathFlowSid { get; }
        /// <summary>
        /// The SID of the Engagement resource to fetch
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchEngagementOptions
        /// </summary>
        /// <param name="pathFlowSid"> Flow SID </param>
        /// <param name="pathSid"> The SID of the Engagement resource to fetch </param>
        public FetchEngagementOptions(string pathFlowSid, string pathSid)
        {
            PathFlowSid = pathFlowSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// Triggers a new Engagement for the Flow
    /// </summary>
    public class CreateEngagementOptions : IOptions<EngagementResource>
    {
        /// <summary>
        /// The SID of the Flow
        /// </summary>
        public string PathFlowSid { get; }
        /// <summary>
        /// The Contact phone number to start a Studio Flow Engagement
        /// </summary>
        public Types.PhoneNumber To { get; }
        /// <summary>
        /// The Twilio phone number to send messages or initiate calls from during the Flow Engagement
        /// </summary>
        public Types.PhoneNumber From { get; }
        /// <summary>
        /// A JSON string we will add to your flow's context and that you can access as variables inside your flow
        /// </summary>
        public object Parameters { get; set; }

        /// <summary>
        /// Construct a new CreateEngagementOptions
        /// </summary>
        /// <param name="pathFlowSid"> The SID of the Flow </param>
        /// <param name="to"> The Contact phone number to start a Studio Flow Engagement </param>
        /// <param name="from"> The Twilio phone number to send messages or initiate calls from during the Flow Engagement
        ///            </param>
        public CreateEngagementOptions(string pathFlowSid, Types.PhoneNumber to, Types.PhoneNumber from)
        {
            PathFlowSid = pathFlowSid;
            To = to;
            From = from;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (To != null)
            {
                p.Add(new KeyValuePair<string, string>("To", To.ToString()));
            }

            if (From != null)
            {
                p.Add(new KeyValuePair<string, string>("From", From.ToString()));
            }

            if (Parameters != null)
            {
                p.Add(new KeyValuePair<string, string>("Parameters", Serializers.JsonObject(Parameters)));
            }

            return p;
        }
    }

    /// <summary>
    /// Delete this Engagement and all Steps relating to it.
    /// </summary>
    public class DeleteEngagementOptions : IOptions<EngagementResource>
    {
        /// <summary>
        /// The SID of the Flow to delete Engagements from
        /// </summary>
        public string PathFlowSid { get; }
        /// <summary>
        /// The SID of the Engagement resource to delete
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteEngagementOptions
        /// </summary>
        /// <param name="pathFlowSid"> The SID of the Flow to delete Engagements from </param>
        /// <param name="pathSid"> The SID of the Engagement resource to delete </param>
        public DeleteEngagementOptions(string pathFlowSid, string pathSid)
        {
            PathFlowSid = pathFlowSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

}