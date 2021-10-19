/*
 * ELEMENTS API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using OpenAPIDateConverter = ElementsSDK.Client.OpenAPIDateConverter;

namespace ElementsSDK.Model
{
    /// <summary>
    /// TaskInfo
    /// </summary>
    [DataContract(Name = "TaskInfo")]
    public partial class TaskInfo : IEquatable<TaskInfo>
    {
        /// <summary>
        /// Defines State
        /// </summary>
        public enum StateEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            NUMBER_0 = 0,

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1,

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            NUMBER_2 = 2,

            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            NUMBER_3 = 3,

            /// <summary>
            /// Enum NUMBER_4 for value: 4
            /// </summary>
            NUMBER_4 = 4,

            /// <summary>
            /// Enum NUMBER_5 for value: 5
            /// </summary>
            NUMBER_5 = 5,

            /// <summary>
            /// Enum NUMBER_6 for value: 6
            /// </summary>
            NUMBER_6 = 6,

            /// <summary>
            /// Enum NUMBER_7 for value: 7
            /// </summary>
            NUMBER_7 = 7

        }


        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TaskInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskInfo" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="kwargs">kwargs (required).</param>
        /// <param name="subtask">subtask.</param>
        /// <param name="worker">worker.</param>
        /// <param name="user">user.</param>
        /// <param name="workstation">workstation.</param>
        /// <param name="progress">progress.</param>
        /// <param name="name">name.</param>
        /// <param name="taskName">taskName.</param>
        /// <param name="workerName">workerName.</param>
        /// <param name="queue">queue.</param>
        /// <param name="state">state.</param>
        /// <param name="stateText">stateText.</param>
        /// <param name="jobInstance">jobInstance.</param>
        /// <param name="exception">exception.</param>
        /// <param name="traceback">traceback.</param>
        /// <param name="schedule">schedule.</param>
        public TaskInfo(string id = default(string), Dictionary<string, string> kwargs = default(Dictionary<string, string>), Subtask subtask = default(Subtask), StorageNodeMini worker = default(StorageNodeMini), ElementsUserMini user = default(ElementsUserMini), Workstation workstation = default(Workstation), TaskProgress progress = default(TaskProgress), string name = default(string), string taskName = default(string), string workerName = default(string), string queue = default(string), StateEnum? state = default(StateEnum?), string stateText = default(string), Guid? jobInstance = default(Guid?), string exception = default(string), string traceback = default(string), int? schedule = default(int?))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for TaskInfo and cannot be null");
            // to ensure "kwargs" is required (not null)
            this.Kwargs = kwargs ?? throw new ArgumentNullException("kwargs is a required property for TaskInfo and cannot be null");
            this.Subtask = subtask;
            this.Worker = worker;
            this.User = user;
            this.Workstation = workstation;
            this.Progress = progress;
            this.Name = name;
            this.TaskName = taskName;
            this.WorkerName = workerName;
            this.Queue = queue;
            this.State = state;
            this.StateText = stateText;
            this.JobInstance = jobInstance;
            this.Exception = exception;
            this.Traceback = traceback;
            this.Schedule = schedule;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "display_name", EmitDefaultValue = false)]
        public string DisplayName { get; private set; }

        /// <summary>
        /// Returns false as DisplayName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDisplayName()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Kwargs
        /// </summary>
        [DataMember(Name = "kwargs", IsRequired = true, EmitDefaultValue = false)]
        public Dictionary<string, string> Kwargs { get; set; }

        /// <summary>
        /// Gets or Sets Subtask
        /// </summary>
        [DataMember(Name = "subtask", EmitDefaultValue = true)]
        public Subtask Subtask { get; set; }

        /// <summary>
        /// Gets or Sets Worker
        /// </summary>
        [DataMember(Name = "worker", EmitDefaultValue = false)]
        public StorageNodeMini Worker { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "user", EmitDefaultValue = false)]
        public ElementsUserMini User { get; set; }

        /// <summary>
        /// Gets or Sets Workstation
        /// </summary>
        [DataMember(Name = "workstation", EmitDefaultValue = false)]
        public Workstation Workstation { get; set; }

        /// <summary>
        /// Gets or Sets Progress
        /// </summary>
        [DataMember(Name = "progress", EmitDefaultValue = false)]
        public TaskProgress Progress { get; set; }

        /// <summary>
        /// Gets or Sets LogPath
        /// </summary>
        [DataMember(Name = "log_path", EmitDefaultValue = false)]
        public string LogPath { get; private set; }

        /// <summary>
        /// Returns false as LogPath should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLogPath()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets TaskName
        /// </summary>
        [DataMember(Name = "task_name", EmitDefaultValue = true)]
        public string TaskName { get; set; }

        /// <summary>
        /// Gets or Sets WorkerName
        /// </summary>
        [DataMember(Name = "worker_name", EmitDefaultValue = true)]
        public string WorkerName { get; set; }

        /// <summary>
        /// Gets or Sets Queue
        /// </summary>
        [DataMember(Name = "queue", EmitDefaultValue = true)]
        public string Queue { get; set; }

        /// <summary>
        /// Gets or Sets StateText
        /// </summary>
        [DataMember(Name = "state_text", EmitDefaultValue = true)]
        public string StateText { get; set; }

        /// <summary>
        /// Gets or Sets JobInstance
        /// </summary>
        [DataMember(Name = "job_instance", EmitDefaultValue = true)]
        public Guid? JobInstance { get; set; }

        /// <summary>
        /// Gets or Sets Started
        /// </summary>
        [DataMember(Name = "started", EmitDefaultValue = false)]
        public DateTime Started { get; private set; }

        /// <summary>
        /// Returns false as Started should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStarted()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Finished
        /// </summary>
        [DataMember(Name = "finished", EmitDefaultValue = false)]
        public DateTime Finished { get; private set; }

        /// <summary>
        /// Returns false as Finished should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFinished()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Exception
        /// </summary>
        [DataMember(Name = "exception", EmitDefaultValue = true)]
        public string Exception { get; set; }

        /// <summary>
        /// Gets or Sets Traceback
        /// </summary>
        [DataMember(Name = "traceback", EmitDefaultValue = true)]
        public string Traceback { get; set; }

        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>
        [DataMember(Name = "schedule", EmitDefaultValue = true)]
        public int? Schedule { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Kwargs: ").Append(Kwargs).Append("\n");
            sb.Append("  Subtask: ").Append(Subtask).Append("\n");
            sb.Append("  Worker: ").Append(Worker).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Workstation: ").Append(Workstation).Append("\n");
            sb.Append("  Progress: ").Append(Progress).Append("\n");
            sb.Append("  LogPath: ").Append(LogPath).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TaskName: ").Append(TaskName).Append("\n");
            sb.Append("  WorkerName: ").Append(WorkerName).Append("\n");
            sb.Append("  Queue: ").Append(Queue).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  StateText: ").Append(StateText).Append("\n");
            sb.Append("  JobInstance: ").Append(JobInstance).Append("\n");
            sb.Append("  Started: ").Append(Started).Append("\n");
            sb.Append("  Finished: ").Append(Finished).Append("\n");
            sb.Append("  Exception: ").Append(Exception).Append("\n");
            sb.Append("  Traceback: ").Append(Traceback).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskInfo);
        }

        /// <summary>
        /// Returns true if TaskInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Kwargs == input.Kwargs ||
                    this.Kwargs != null &&
                    input.Kwargs != null &&
                    this.Kwargs.SequenceEqual(input.Kwargs)
                ) && 
                (
                    this.Subtask == input.Subtask ||
                    (this.Subtask != null &&
                    this.Subtask.Equals(input.Subtask))
                ) && 
                (
                    this.Worker == input.Worker ||
                    (this.Worker != null &&
                    this.Worker.Equals(input.Worker))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.Workstation == input.Workstation ||
                    (this.Workstation != null &&
                    this.Workstation.Equals(input.Workstation))
                ) && 
                (
                    this.Progress == input.Progress ||
                    (this.Progress != null &&
                    this.Progress.Equals(input.Progress))
                ) && 
                (
                    this.LogPath == input.LogPath ||
                    (this.LogPath != null &&
                    this.LogPath.Equals(input.LogPath))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.TaskName == input.TaskName ||
                    (this.TaskName != null &&
                    this.TaskName.Equals(input.TaskName))
                ) && 
                (
                    this.WorkerName == input.WorkerName ||
                    (this.WorkerName != null &&
                    this.WorkerName.Equals(input.WorkerName))
                ) && 
                (
                    this.Queue == input.Queue ||
                    (this.Queue != null &&
                    this.Queue.Equals(input.Queue))
                ) && 
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
                ) && 
                (
                    this.StateText == input.StateText ||
                    (this.StateText != null &&
                    this.StateText.Equals(input.StateText))
                ) && 
                (
                    this.JobInstance == input.JobInstance ||
                    (this.JobInstance != null &&
                    this.JobInstance.Equals(input.JobInstance))
                ) && 
                (
                    this.Started == input.Started ||
                    (this.Started != null &&
                    this.Started.Equals(input.Started))
                ) && 
                (
                    this.Finished == input.Finished ||
                    (this.Finished != null &&
                    this.Finished.Equals(input.Finished))
                ) && 
                (
                    this.Exception == input.Exception ||
                    (this.Exception != null &&
                    this.Exception.Equals(input.Exception))
                ) && 
                (
                    this.Traceback == input.Traceback ||
                    (this.Traceback != null &&
                    this.Traceback.Equals(input.Traceback))
                ) && 
                (
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Kwargs != null)
                    hashCode = hashCode * 59 + this.Kwargs.GetHashCode();
                if (this.Subtask != null)
                    hashCode = hashCode * 59 + this.Subtask.GetHashCode();
                if (this.Worker != null)
                    hashCode = hashCode * 59 + this.Worker.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Workstation != null)
                    hashCode = hashCode * 59 + this.Workstation.GetHashCode();
                if (this.Progress != null)
                    hashCode = hashCode * 59 + this.Progress.GetHashCode();
                if (this.LogPath != null)
                    hashCode = hashCode * 59 + this.LogPath.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.TaskName != null)
                    hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                if (this.WorkerName != null)
                    hashCode = hashCode * 59 + this.WorkerName.GetHashCode();
                if (this.Queue != null)
                    hashCode = hashCode * 59 + this.Queue.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.StateText != null)
                    hashCode = hashCode * 59 + this.StateText.GetHashCode();
                if (this.JobInstance != null)
                    hashCode = hashCode * 59 + this.JobInstance.GetHashCode();
                if (this.Started != null)
                    hashCode = hashCode * 59 + this.Started.GetHashCode();
                if (this.Finished != null)
                    hashCode = hashCode * 59 + this.Finished.GetHashCode();
                if (this.Exception != null)
                    hashCode = hashCode * 59 + this.Exception.GetHashCode();
                if (this.Traceback != null)
                    hashCode = hashCode * 59 + this.Traceback.GetHashCode();
                if (this.Schedule != null)
                    hashCode = hashCode * 59 + this.Schedule.GetHashCode();
                return hashCode;
            }
        }

    }

}
