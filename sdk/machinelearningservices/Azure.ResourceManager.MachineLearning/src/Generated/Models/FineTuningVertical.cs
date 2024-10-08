// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Please note <see cref="FineTuningVertical"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AzureOpenAiFineTuning"/> and <see cref="CustomModelFineTuning"/>.
    /// </summary>
    public abstract partial class FineTuningVertical
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FineTuningVertical"/>. </summary>
        /// <param name="taskType"> [Required] Fine tuning task type. </param>
        /// <param name="trainingData">
        /// [Required] Training data for fine tuning.
        /// Please note <see cref="MachineLearningJobInput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningCustomModelJobInput"/>, <see cref="MachineLearningLiteralJobInput"/>, <see cref="MachineLearningFlowModelJobInput"/>, <see cref="MachineLearningTableJobInput"/>, <see cref="MachineLearningTritonModelJobInput"/>, <see cref="MachineLearningUriFileJobInput"/> and <see cref="MachineLearningUriFolderJobInput"/>.
        /// </param>
        /// <param name="model"> [Required] Input model for fine tuning. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="trainingData"/> or <paramref name="model"/> is null. </exception>
        protected FineTuningVertical(FineTuningTaskType taskType, MachineLearningJobInput trainingData, MachineLearningFlowModelJobInput model)
        {
            Argument.AssertNotNull(trainingData, nameof(trainingData));
            Argument.AssertNotNull(model, nameof(model));

            TaskType = taskType;
            TrainingData = trainingData;
            Model = model;
        }

        /// <summary> Initializes a new instance of <see cref="FineTuningVertical"/>. </summary>
        /// <param name="modelProvider"> [Required] Enum to determine the type of fine tuning. </param>
        /// <param name="taskType"> [Required] Fine tuning task type. </param>
        /// <param name="trainingData">
        /// [Required] Training data for fine tuning.
        /// Please note <see cref="MachineLearningJobInput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningCustomModelJobInput"/>, <see cref="MachineLearningLiteralJobInput"/>, <see cref="MachineLearningFlowModelJobInput"/>, <see cref="MachineLearningTableJobInput"/>, <see cref="MachineLearningTritonModelJobInput"/>, <see cref="MachineLearningUriFileJobInput"/> and <see cref="MachineLearningUriFolderJobInput"/>.
        /// </param>
        /// <param name="validationData">
        /// Validation data for fine tuning.
        /// Please note <see cref="MachineLearningJobInput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningCustomModelJobInput"/>, <see cref="MachineLearningLiteralJobInput"/>, <see cref="MachineLearningFlowModelJobInput"/>, <see cref="MachineLearningTableJobInput"/>, <see cref="MachineLearningTritonModelJobInput"/>, <see cref="MachineLearningUriFileJobInput"/> and <see cref="MachineLearningUriFolderJobInput"/>.
        /// </param>
        /// <param name="model"> [Required] Input model for fine tuning. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FineTuningVertical(ModelProvider modelProvider, FineTuningTaskType taskType, MachineLearningJobInput trainingData, MachineLearningJobInput validationData, MachineLearningFlowModelJobInput model, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ModelProvider = modelProvider;
            TaskType = taskType;
            TrainingData = trainingData;
            ValidationData = validationData;
            Model = model;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="FineTuningVertical"/> for deserialization. </summary>
        internal FineTuningVertical()
        {
        }

        /// <summary> [Required] Enum to determine the type of fine tuning. </summary>
        internal ModelProvider ModelProvider { get; set; }
        /// <summary> [Required] Fine tuning task type. </summary>
        public FineTuningTaskType TaskType { get; set; }
        /// <summary>
        /// [Required] Training data for fine tuning.
        /// Please note <see cref="MachineLearningJobInput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningCustomModelJobInput"/>, <see cref="MachineLearningLiteralJobInput"/>, <see cref="MachineLearningFlowModelJobInput"/>, <see cref="MachineLearningTableJobInput"/>, <see cref="MachineLearningTritonModelJobInput"/>, <see cref="MachineLearningUriFileJobInput"/> and <see cref="MachineLearningUriFolderJobInput"/>.
        /// </summary>
        public MachineLearningJobInput TrainingData { get; set; }
        /// <summary>
        /// Validation data for fine tuning.
        /// Please note <see cref="MachineLearningJobInput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningCustomModelJobInput"/>, <see cref="MachineLearningLiteralJobInput"/>, <see cref="MachineLearningFlowModelJobInput"/>, <see cref="MachineLearningTableJobInput"/>, <see cref="MachineLearningTritonModelJobInput"/>, <see cref="MachineLearningUriFileJobInput"/> and <see cref="MachineLearningUriFolderJobInput"/>.
        /// </summary>
        public MachineLearningJobInput ValidationData { get; set; }
        /// <summary> [Required] Input model for fine tuning. </summary>
        public MachineLearningFlowModelJobInput Model { get; set; }
    }
}
