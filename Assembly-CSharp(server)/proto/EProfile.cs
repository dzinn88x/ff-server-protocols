using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005FE RID: 1534
	[Token(Token = "0x20005FE")]
	[ProtoContract]
	public class EProfile
	{
		// Token: 0x0600237E RID: 9086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600237E")]
		[Address(RVA = "0x21B9B1C", Offset = "0x21B9B1C", VA = "0x7BBC9B9B1C")]
		public EProfile()
		{
		}

		// Token: 0x020005FF RID: 1535
		[Token(Token = "0x20005FF")]
		[ProtoContract]
		public enum TaskState
		{
			// Token: 0x04001E9A RID: 7834
			[Token(Token = "0x4001E9A")]
			TaskState_RECEIVED,
			// Token: 0x04001E9B RID: 7835
			[Token(Token = "0x4001E9B")]
			TaskState_FINISHED,
			// Token: 0x04001E9C RID: 7836
			[Token(Token = "0x4001E9C")]
			TaskState_AWARDED
		}

		// Token: 0x02000600 RID: 1536
		[Token(Token = "0x2000600")]
		[ProtoContract]
		public enum TaskType
		{
			// Token: 0x04001E9E RID: 7838
			[Token(Token = "0x4001E9E")]
			TaskType_NONE,
			// Token: 0x04001E9F RID: 7839
			[Token(Token = "0x4001E9F")]
			TaskType_MOVE_DISTANCE,
			// Token: 0x04001EA0 RID: 7840
			[Token(Token = "0x4001EA0")]
			TaskType_KILL,
			// Token: 0x04001EA1 RID: 7841
			[Token(Token = "0x4001EA1")]
			TaskType_WIN,
			// Token: 0x04001EA2 RID: 7842
			[Token(Token = "0x4001EA2")]
			TaskType_GROUP_WITH_FRIEND,
			// Token: 0x04001EA3 RID: 7843
			[Token(Token = "0x4001EA3")]
			TaskType_TASK_FINISHED_CUMU,
			// Token: 0x04001EA4 RID: 7844
			[Token(Token = "0x4001EA4")]
			TaskType_ITEM_COLLECT,
			// Token: 0x04001EA5 RID: 7845
			[Token(Token = "0x4001EA5")]
			TaskType_WEAPON_DAMAGE,
			// Token: 0x04001EA6 RID: 7846
			[Token(Token = "0x4001EA6")]
			TaskType_WEAPON_KILL,
			// Token: 0x04001EA7 RID: 7847
			[Token(Token = "0x4001EA7")]
			TaskType_REVIVAL_COUNT,
			// Token: 0x04001EA8 RID: 7848
			[Token(Token = "0x4001EA8")]
			TaskType_WEAPON_TYPE_KILL,
			// Token: 0x04001EA9 RID: 7849
			[Token(Token = "0x4001EA9")]
			TaskType_LOW_HP_KILL
		}

		// Token: 0x02000601 RID: 1537
		[Token(Token = "0x2000601")]
		[ProtoContract]
		public enum DispatchLine
		{
			// Token: 0x04001EAB RID: 7851
			[Token(Token = "0x4001EAB")]
			DispatchLine_NONE,
			// Token: 0x04001EAC RID: 7852
			[Token(Token = "0x4001EAC")]
			DispatchLine_FIRST,
			// Token: 0x04001EAD RID: 7853
			[Token(Token = "0x4001EAD")]
			DispatchLine_SECOND,
			// Token: 0x04001EAE RID: 7854
			[Token(Token = "0x4001EAE")]
			DispatchLine_THIRD,
			// Token: 0x04001EAF RID: 7855
			[Token(Token = "0x4001EAF")]
			DispatchLine_FOURTH
		}

		// Token: 0x02000602 RID: 1538
		[Token(Token = "0x2000602")]
		[ProtoContract]
		public enum DispatchQuestState
		{
			// Token: 0x04001EB1 RID: 7857
			[Token(Token = "0x4001EB1")]
			DispatchQuestState_NONE,
			// Token: 0x04001EB2 RID: 7858
			[Token(Token = "0x4001EB2")]
			DispatchQuestState_PROCESSING,
			// Token: 0x04001EB3 RID: 7859
			[Token(Token = "0x4001EB3")]
			DispatchQuestState_FINISHED
		}
	}
}
