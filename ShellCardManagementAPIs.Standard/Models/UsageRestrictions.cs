// <copyright file="UsageRestrictions.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace ShellCardManagementAPIs.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using APIMatic.Core.Utilities.Converters;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using ShellCardManagementAPIs.Standard;
    using ShellCardManagementAPIs.Standard.Utilities;

    /// <summary>
    /// UsageRestrictions.
    /// </summary>
    public class UsageRestrictions
    {
        private double? dailySpend;
        private double? weeklySpend;
        private double? monthlySpend;
        private double? perTransactionSpend;
        private int? dailyVolume;
        private int? weeklyVolume;
        private int? monthlyVolume;
        private int? perTransactionVolume;
        private double? dailyTransactionCount;
        private double? weeklyTransactionCount;
        private double? monthlyTransactionCount;
        private double? annualSpend;
        private double? lifeTimeSpend;
        private double? annualVolume;
        private double? lifeTimeVolume;
        private double? annualTransactionCount;
        private double? lifeTimeTransactionCount;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "DailySpend", false },
            { "WeeklySpend", false },
            { "MonthlySpend", false },
            { "PerTransactionSpend", false },
            { "DailyVolume", false },
            { "WeeklyVolume", false },
            { "MonthlyVolume", false },
            { "PerTransactionVolume", false },
            { "DailyTransactionCount", false },
            { "WeeklyTransactionCount", false },
            { "MonthlyTransactionCount", false },
            { "AnnualSpend", false },
            { "LifeTimeSpend", false },
            { "AnnualVolume", false },
            { "LifeTimeVolume", false },
            { "AnnualTransactionCount", false },
            { "LifeTimeTransactionCount", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageRestrictions"/> class.
        /// </summary>
        public UsageRestrictions()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageRestrictions"/> class.
        /// </summary>
        /// <param name="dailySpend">DailySpend.</param>
        /// <param name="weeklySpend">WeeklySpend.</param>
        /// <param name="monthlySpend">MonthlySpend.</param>
        /// <param name="perTransactionSpend">PerTransactionSpend.</param>
        /// <param name="dailyVolume">DailyVolume.</param>
        /// <param name="weeklyVolume">WeeklyVolume.</param>
        /// <param name="monthlyVolume">MonthlyVolume.</param>
        /// <param name="perTransactionVolume">PerTransactionVolume.</param>
        /// <param name="dailyTransactionCount">DailyTransactionCount.</param>
        /// <param name="weeklyTransactionCount">WeeklyTransactionCount.</param>
        /// <param name="monthlyTransactionCount">MonthlyTransactionCount.</param>
        /// <param name="annualSpend">AnnualSpend.</param>
        /// <param name="lifeTimeSpend">LifeTimeSpend.</param>
        /// <param name="annualVolume">AnnualVolume.</param>
        /// <param name="lifeTimeVolume">LifeTimeVolume.</param>
        /// <param name="annualTransactionCount">AnnualTransactionCount.</param>
        /// <param name="lifeTimeTransactionCount">LifeTimeTransactionCount.</param>
        public UsageRestrictions(
            double? dailySpend = null,
            double? weeklySpend = null,
            double? monthlySpend = null,
            double? perTransactionSpend = null,
            int? dailyVolume = null,
            int? weeklyVolume = null,
            int? monthlyVolume = null,
            int? perTransactionVolume = null,
            double? dailyTransactionCount = null,
            double? weeklyTransactionCount = null,
            double? monthlyTransactionCount = null,
            double? annualSpend = null,
            double? lifeTimeSpend = null,
            double? annualVolume = null,
            double? lifeTimeVolume = null,
            double? annualTransactionCount = null,
            double? lifeTimeTransactionCount = null)
        {
            if (dailySpend != null)
            {
                this.DailySpend = dailySpend;
            }

            if (weeklySpend != null)
            {
                this.WeeklySpend = weeklySpend;
            }

            if (monthlySpend != null)
            {
                this.MonthlySpend = monthlySpend;
            }

            if (perTransactionSpend != null)
            {
                this.PerTransactionSpend = perTransactionSpend;
            }

            if (dailyVolume != null)
            {
                this.DailyVolume = dailyVolume;
            }

            if (weeklyVolume != null)
            {
                this.WeeklyVolume = weeklyVolume;
            }

            if (monthlyVolume != null)
            {
                this.MonthlyVolume = monthlyVolume;
            }

            if (perTransactionVolume != null)
            {
                this.PerTransactionVolume = perTransactionVolume;
            }

            if (dailyTransactionCount != null)
            {
                this.DailyTransactionCount = dailyTransactionCount;
            }

            if (weeklyTransactionCount != null)
            {
                this.WeeklyTransactionCount = weeklyTransactionCount;
            }

            if (monthlyTransactionCount != null)
            {
                this.MonthlyTransactionCount = monthlyTransactionCount;
            }

            if (annualSpend != null)
            {
                this.AnnualSpend = annualSpend;
            }

            if (lifeTimeSpend != null)
            {
                this.LifeTimeSpend = lifeTimeSpend;
            }

            if (annualVolume != null)
            {
                this.AnnualVolume = annualVolume;
            }

            if (lifeTimeVolume != null)
            {
                this.LifeTimeVolume = lifeTimeVolume;
            }

            if (annualTransactionCount != null)
            {
                this.AnnualTransactionCount = annualTransactionCount;
            }

            if (lifeTimeTransactionCount != null)
            {
                this.LifeTimeTransactionCount = lifeTimeTransactionCount;
            }

        }

        /// <summary>
        /// Maximum spend value (amount) allowed per day.
        /// Optional
        /// The value ‘0’ represents not set. If Values is passed as null, will be considered as inherited.
        /// Valid range: 0 to 9999999999
        /// </summary>
        [JsonProperty("DailySpend")]
        public double? DailySpend
        {
            get
            {
                return this.dailySpend;
            }

            set
            {
                this.shouldSerialize["DailySpend"] = true;
                this.dailySpend = value;
            }
        }

        /// <summary>
        /// Maximum spend value (amount) allowed per week.
        /// Optional
        /// The value ‘0’ represents not set. If Values is passed as null, will be considered as inherited.
        /// Valid range: 0 to 9999999999
        /// </summary>
        [JsonProperty("WeeklySpend")]
        public double? WeeklySpend
        {
            get
            {
                return this.weeklySpend;
            }

            set
            {
                this.shouldSerialize["WeeklySpend"] = true;
                this.weeklySpend = value;
            }
        }

        /// <summary>
        /// Maximum spend value (amount) allowed per month.
        /// Optional
        /// The value ‘0’ represents not set. If Values is passed as null, will be considered as inherited.
        /// Valid range: 0 to 9999999999
        /// </summary>
        [JsonProperty("MonthlySpend")]
        public double? MonthlySpend
        {
            get
            {
                return this.monthlySpend;
            }

            set
            {
                this.shouldSerialize["MonthlySpend"] = true;
                this.monthlySpend = value;
            }
        }

        /// <summary>
        /// Maximum spend value (amount) allowed per transaction.
        /// Optional
        /// The value ‘0’ represents not set. If Values is passed as null, will be considered as inherited.
        /// Valid range: 0 to 9999999999
        /// </summary>
        [JsonProperty("PerTransactionSpend")]
        public double? PerTransactionSpend
        {
            get
            {
                return this.perTransactionSpend;
            }

            set
            {
                this.shouldSerialize["PerTransactionSpend"] = true;
                this.perTransactionSpend = value;
            }
        }

        /// <summary>
        /// Maximum volume (quantity) allowed per day.
        /// Optional
        /// The value ‘0’ represents not set. If Values is passed as null, will be considered as inherited.
        /// Valid range: 0 to 9999999999
        /// </summary>
        [JsonProperty("DailyVolume")]
        public int? DailyVolume
        {
            get
            {
                return this.dailyVolume;
            }

            set
            {
                this.shouldSerialize["DailyVolume"] = true;
                this.dailyVolume = value;
            }
        }

        /// <summary>
        /// Maximum volume (quantity) allowed per week.
        /// Optional
        /// The value ‘0’ represents not set. If Values is passed as null, will be considered as inherited.
        /// Valid range: 0 to 9999999999
        /// </summary>
        [JsonProperty("WeeklyVolume")]
        public int? WeeklyVolume
        {
            get
            {
                return this.weeklyVolume;
            }

            set
            {
                this.shouldSerialize["WeeklyVolume"] = true;
                this.weeklyVolume = value;
            }
        }

        /// <summary>
        /// Maximum volume (quantity) allowed per month.
        /// Optional
        /// The value ‘0’ represents not set. If Values is passed as null, will be considered as inherited.
        /// Valid range: 0 to 9999999999
        /// </summary>
        [JsonProperty("MonthlyVolume")]
        public int? MonthlyVolume
        {
            get
            {
                return this.monthlyVolume;
            }

            set
            {
                this.shouldSerialize["MonthlyVolume"] = true;
                this.monthlyVolume = value;
            }
        }

        /// <summary>
        /// Maximum volume (quantity) allowed per transaction.
        /// Optional
        /// The value ‘0’ represents not set. If Values is passed as null, will be considered as inherited.
        /// Valid range: 0 to 9999999999
        /// </summary>
        [JsonProperty("PerTransactionVolume")]
        public int? PerTransactionVolume
        {
            get
            {
                return this.perTransactionVolume;
            }

            set
            {
                this.shouldSerialize["PerTransactionVolume"] = true;
                this.perTransactionVolume = value;
            }
        }

        /// <summary>
        /// Maximum number of transactions allowed per day.
        /// Optional
        /// The value ‘0’ represents not set. If Values is passed as null, will be considered as inherited.
        /// Valid range: 0 to 9999999999
        /// </summary>
        [JsonProperty("DailyTransactionCount")]
        public double? DailyTransactionCount
        {
            get
            {
                return this.dailyTransactionCount;
            }

            set
            {
                this.shouldSerialize["DailyTransactionCount"] = true;
                this.dailyTransactionCount = value;
            }
        }

        /// <summary>
        /// Maximum number of transactions allowed per week.
        /// Optional
        /// The value ‘0’ represents not set. If Values is passed as null, will be considered as inherited.
        /// Valid range: 0 to 9999999999
        /// </summary>
        [JsonProperty("WeeklyTransactionCount")]
        public double? WeeklyTransactionCount
        {
            get
            {
                return this.weeklyTransactionCount;
            }

            set
            {
                this.shouldSerialize["WeeklyTransactionCount"] = true;
                this.weeklyTransactionCount = value;
            }
        }

        /// <summary>
        /// Maximum number of transactions allowed per month.
        /// Optional.
        /// The value ‘0’ represents not set. If Values is passed as null, will be considered as inherited.
        /// Valid range: 0 to 9999999999
        /// </summary>
        [JsonProperty("MonthlyTransactionCount")]
        public double? MonthlyTransactionCount
        {
            get
            {
                return this.monthlyTransactionCount;
            }

            set
            {
                this.shouldSerialize["MonthlyTransactionCount"] = true;
                this.monthlyTransactionCount = value;
            }
        }

        /// <summary>
        /// Maximum spend value (amount) allowed per annum.
        /// Optional
        /// The value ‘0’ represents not set. If Values is passed as null, will be considered as inherited.
        /// Valid range: 0 to 9999999999
        /// </summary>
        [JsonProperty("AnnualSpend")]
        public double? AnnualSpend
        {
            get
            {
                return this.annualSpend;
            }

            set
            {
                this.shouldSerialize["AnnualSpend"] = true;
                this.annualSpend = value;
            }
        }

        /// <summary>
        /// Maximum spend value (amount) allowed in card’s life time.
        /// Optional
        /// The value ‘0’ represents not set. If Values is passed as null, will be considered as inherited.
        /// Valid range: 0 to 9999999999
        /// </summary>
        [JsonProperty("LifeTimeSpend")]
        public double? LifeTimeSpend
        {
            get
            {
                return this.lifeTimeSpend;
            }

            set
            {
                this.shouldSerialize["LifeTimeSpend"] = true;
                this.lifeTimeSpend = value;
            }
        }

        /// <summary>
        /// Maximum volume (quantity) allowed per annum.
        /// Optional
        /// The value ‘0’ represents not set. If Values is passed as null, will be considered as inherited.
        /// Valid range: 0 to 9999999999
        /// </summary>
        [JsonProperty("AnnualVolume")]
        public double? AnnualVolume
        {
            get
            {
                return this.annualVolume;
            }

            set
            {
                this.shouldSerialize["AnnualVolume"] = true;
                this.annualVolume = value;
            }
        }

        /// <summary>
        /// Maximum volume (quantity) allowed in card’s life time.
        /// Optional
        /// The value ‘0’ represents not set. If Values is passed as null, will be considered as inherited.
        /// Valid range: 0 to 9999999999
        /// </summary>
        [JsonProperty("LifeTimeVolume")]
        public double? LifeTimeVolume
        {
            get
            {
                return this.lifeTimeVolume;
            }

            set
            {
                this.shouldSerialize["LifeTimeVolume"] = true;
                this.lifeTimeVolume = value;
            }
        }

        /// <summary>
        /// Maximum number of transactions allowed per annum.
        /// Optional.
        /// The value ‘0’ represents not set. If Values is passed as null, will be considered as inherited.
        /// Valid range: 0 to 9999999999
        /// </summary>
        [JsonProperty("AnnualTransactionCount")]
        public double? AnnualTransactionCount
        {
            get
            {
                return this.annualTransactionCount;
            }

            set
            {
                this.shouldSerialize["AnnualTransactionCount"] = true;
                this.annualTransactionCount = value;
            }
        }

        /// <summary>
        /// Maximum number of transactions allowed in card’s lifetime.
        /// Optional
        /// The value ‘0’ represents not set. If Values is passed as null, will be considered as inherited.
        /// Valid range: 0 to 9999999999
        /// </summary>
        [JsonProperty("LifeTimeTransactionCount")]
        public double? LifeTimeTransactionCount
        {
            get
            {
                return this.lifeTimeTransactionCount;
            }

            set
            {
                this.shouldSerialize["LifeTimeTransactionCount"] = true;
                this.lifeTimeTransactionCount = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UsageRestrictions : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDailySpend()
        {
            this.shouldSerialize["DailySpend"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetWeeklySpend()
        {
            this.shouldSerialize["WeeklySpend"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetMonthlySpend()
        {
            this.shouldSerialize["MonthlySpend"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPerTransactionSpend()
        {
            this.shouldSerialize["PerTransactionSpend"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDailyVolume()
        {
            this.shouldSerialize["DailyVolume"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetWeeklyVolume()
        {
            this.shouldSerialize["WeeklyVolume"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetMonthlyVolume()
        {
            this.shouldSerialize["MonthlyVolume"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPerTransactionVolume()
        {
            this.shouldSerialize["PerTransactionVolume"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDailyTransactionCount()
        {
            this.shouldSerialize["DailyTransactionCount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetWeeklyTransactionCount()
        {
            this.shouldSerialize["WeeklyTransactionCount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetMonthlyTransactionCount()
        {
            this.shouldSerialize["MonthlyTransactionCount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAnnualSpend()
        {
            this.shouldSerialize["AnnualSpend"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLifeTimeSpend()
        {
            this.shouldSerialize["LifeTimeSpend"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAnnualVolume()
        {
            this.shouldSerialize["AnnualVolume"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLifeTimeVolume()
        {
            this.shouldSerialize["LifeTimeVolume"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAnnualTransactionCount()
        {
            this.shouldSerialize["AnnualTransactionCount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLifeTimeTransactionCount()
        {
            this.shouldSerialize["LifeTimeTransactionCount"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDailySpend()
        {
            return this.shouldSerialize["DailySpend"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeWeeklySpend()
        {
            return this.shouldSerialize["WeeklySpend"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMonthlySpend()
        {
            return this.shouldSerialize["MonthlySpend"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePerTransactionSpend()
        {
            return this.shouldSerialize["PerTransactionSpend"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDailyVolume()
        {
            return this.shouldSerialize["DailyVolume"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeWeeklyVolume()
        {
            return this.shouldSerialize["WeeklyVolume"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMonthlyVolume()
        {
            return this.shouldSerialize["MonthlyVolume"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePerTransactionVolume()
        {
            return this.shouldSerialize["PerTransactionVolume"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDailyTransactionCount()
        {
            return this.shouldSerialize["DailyTransactionCount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeWeeklyTransactionCount()
        {
            return this.shouldSerialize["WeeklyTransactionCount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMonthlyTransactionCount()
        {
            return this.shouldSerialize["MonthlyTransactionCount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAnnualSpend()
        {
            return this.shouldSerialize["AnnualSpend"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLifeTimeSpend()
        {
            return this.shouldSerialize["LifeTimeSpend"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAnnualVolume()
        {
            return this.shouldSerialize["AnnualVolume"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLifeTimeVolume()
        {
            return this.shouldSerialize["LifeTimeVolume"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAnnualTransactionCount()
        {
            return this.shouldSerialize["AnnualTransactionCount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLifeTimeTransactionCount()
        {
            return this.shouldSerialize["LifeTimeTransactionCount"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is UsageRestrictions other &&                ((this.DailySpend == null && other.DailySpend == null) || (this.DailySpend?.Equals(other.DailySpend) == true)) &&
                ((this.WeeklySpend == null && other.WeeklySpend == null) || (this.WeeklySpend?.Equals(other.WeeklySpend) == true)) &&
                ((this.MonthlySpend == null && other.MonthlySpend == null) || (this.MonthlySpend?.Equals(other.MonthlySpend) == true)) &&
                ((this.PerTransactionSpend == null && other.PerTransactionSpend == null) || (this.PerTransactionSpend?.Equals(other.PerTransactionSpend) == true)) &&
                ((this.DailyVolume == null && other.DailyVolume == null) || (this.DailyVolume?.Equals(other.DailyVolume) == true)) &&
                ((this.WeeklyVolume == null && other.WeeklyVolume == null) || (this.WeeklyVolume?.Equals(other.WeeklyVolume) == true)) &&
                ((this.MonthlyVolume == null && other.MonthlyVolume == null) || (this.MonthlyVolume?.Equals(other.MonthlyVolume) == true)) &&
                ((this.PerTransactionVolume == null && other.PerTransactionVolume == null) || (this.PerTransactionVolume?.Equals(other.PerTransactionVolume) == true)) &&
                ((this.DailyTransactionCount == null && other.DailyTransactionCount == null) || (this.DailyTransactionCount?.Equals(other.DailyTransactionCount) == true)) &&
                ((this.WeeklyTransactionCount == null && other.WeeklyTransactionCount == null) || (this.WeeklyTransactionCount?.Equals(other.WeeklyTransactionCount) == true)) &&
                ((this.MonthlyTransactionCount == null && other.MonthlyTransactionCount == null) || (this.MonthlyTransactionCount?.Equals(other.MonthlyTransactionCount) == true)) &&
                ((this.AnnualSpend == null && other.AnnualSpend == null) || (this.AnnualSpend?.Equals(other.AnnualSpend) == true)) &&
                ((this.LifeTimeSpend == null && other.LifeTimeSpend == null) || (this.LifeTimeSpend?.Equals(other.LifeTimeSpend) == true)) &&
                ((this.AnnualVolume == null && other.AnnualVolume == null) || (this.AnnualVolume?.Equals(other.AnnualVolume) == true)) &&
                ((this.LifeTimeVolume == null && other.LifeTimeVolume == null) || (this.LifeTimeVolume?.Equals(other.LifeTimeVolume) == true)) &&
                ((this.AnnualTransactionCount == null && other.AnnualTransactionCount == null) || (this.AnnualTransactionCount?.Equals(other.AnnualTransactionCount) == true)) &&
                ((this.LifeTimeTransactionCount == null && other.LifeTimeTransactionCount == null) || (this.LifeTimeTransactionCount?.Equals(other.LifeTimeTransactionCount) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DailySpend = {(this.DailySpend == null ? "null" : this.DailySpend.ToString())}");
            toStringOutput.Add($"this.WeeklySpend = {(this.WeeklySpend == null ? "null" : this.WeeklySpend.ToString())}");
            toStringOutput.Add($"this.MonthlySpend = {(this.MonthlySpend == null ? "null" : this.MonthlySpend.ToString())}");
            toStringOutput.Add($"this.PerTransactionSpend = {(this.PerTransactionSpend == null ? "null" : this.PerTransactionSpend.ToString())}");
            toStringOutput.Add($"this.DailyVolume = {(this.DailyVolume == null ? "null" : this.DailyVolume.ToString())}");
            toStringOutput.Add($"this.WeeklyVolume = {(this.WeeklyVolume == null ? "null" : this.WeeklyVolume.ToString())}");
            toStringOutput.Add($"this.MonthlyVolume = {(this.MonthlyVolume == null ? "null" : this.MonthlyVolume.ToString())}");
            toStringOutput.Add($"this.PerTransactionVolume = {(this.PerTransactionVolume == null ? "null" : this.PerTransactionVolume.ToString())}");
            toStringOutput.Add($"this.DailyTransactionCount = {(this.DailyTransactionCount == null ? "null" : this.DailyTransactionCount.ToString())}");
            toStringOutput.Add($"this.WeeklyTransactionCount = {(this.WeeklyTransactionCount == null ? "null" : this.WeeklyTransactionCount.ToString())}");
            toStringOutput.Add($"this.MonthlyTransactionCount = {(this.MonthlyTransactionCount == null ? "null" : this.MonthlyTransactionCount.ToString())}");
            toStringOutput.Add($"this.AnnualSpend = {(this.AnnualSpend == null ? "null" : this.AnnualSpend.ToString())}");
            toStringOutput.Add($"this.LifeTimeSpend = {(this.LifeTimeSpend == null ? "null" : this.LifeTimeSpend.ToString())}");
            toStringOutput.Add($"this.AnnualVolume = {(this.AnnualVolume == null ? "null" : this.AnnualVolume.ToString())}");
            toStringOutput.Add($"this.LifeTimeVolume = {(this.LifeTimeVolume == null ? "null" : this.LifeTimeVolume.ToString())}");
            toStringOutput.Add($"this.AnnualTransactionCount = {(this.AnnualTransactionCount == null ? "null" : this.AnnualTransactionCount.ToString())}");
            toStringOutput.Add($"this.LifeTimeTransactionCount = {(this.LifeTimeTransactionCount == null ? "null" : this.LifeTimeTransactionCount.ToString())}");
        }
    }
}