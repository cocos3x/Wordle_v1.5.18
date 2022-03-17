namespace SA.Fitness
{
	public sealed class DataType
	{
		public static DataType AGGREGATE_ACTIVITY_SUMMARY;

		public static DataType AGGREGATE_BASAL_METABOLIC_RATE_SUMMARY;

		public static DataType AGGREGATE_BODY_FAT_PERCENTAGE_SUMMARY;

		public static DataType AGGREGATE_CALORIES_EXPENDED;

		public static DataType AGGREGATE_DISTANCE_DELTA;

		public static DataType AGGREGATE_HEART_RATE_SUMMARY;

		public static DataType AGGREGATE_HYDRATION;

		public static DataType AGGREGATE_LOCATION_BOUNDING_BOX;

		public static DataType AGGREGATE_NUTRITION_SUMMARY;

		public static DataType AGGREGATE_POWER_SUMMARY;

		public static DataType AGGREGATE_SPEED_SUMMARY;

		public static DataType AGGREGATE_STEP_COUNT_DELTA;

		public static DataType AGGREGATE_WEIGHT_SUMMARY;

		public static DataType TYPE_ACTIVITY_SAMPLES;

		public static DataType TYPE_ACTIVITY_SEGMENT;

		public static DataType TYPE_BASAL_METABOLIC_RATE;

		public static DataType TYPE_BODY_FAT_PERCENTAGE;

		public static DataType TYPE_CALORIES_EXPENDED;

		public static DataType TYPE_CYCLING_PEDALING_CADENCE;

		public static DataType TYPE_CYCLING_PEDALING_CUMULATIVE;

		public static DataType TYPE_CYCLING_WHEEL_REVOLUTION;

		public static DataType TYPE_CYCLING_WHEEL_RPM;

		public static DataType TYPE_DISTANCE_DELTA;

		public static DataType TYPE_HEART_RATE_BPM;

		public static DataType TYPE_HEIGHT;

		public static DataType TYPE_HYDRATION;

		public static DataType TYPE_LOCATION_SAMPLE;

		public static DataType TYPE_LOCATION_TRACK;

		public static DataType TYPE_NUTRITION;

		public static DataType TYPE_POWER_SAMPLE;

		public static DataType TYPE_SPEED;

		public static DataType TYPE_STEP_COUNT_CADENCE;

		public static DataType TYPE_STEP_COUNT_DELTA;

		public static DataType TYPE_WEIGHT;

		public static DataType TYPE_WORKOUT_EXERCISE;

		private string value;

		public string Value => "";

		private DataType()
		{
		}

		internal DataType(string dataType)
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
