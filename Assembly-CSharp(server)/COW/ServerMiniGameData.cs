using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using SimpleJSON;

namespace COW
{
	// Token: 0x02001198 RID: 4504
	[Token(Token = "0x2001198")]
	public class ServerMiniGameData : IJsonGameData
	{
		// Token: 0x06004614 RID: 17940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004614")]
		[Address(RVA = "0x1B33CF8", Offset = "0x1B33CF8", VA = "0x7BBC333CF8", Slot = "4")]
		public void LoadDataFromJsonData(JSONNode jObject)
		{
		}

		// Token: 0x06004615 RID: 17941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004615")]
		[Address(RVA = "0x1B34184", Offset = "0x1B34184", VA = "0x7BBC334184")]
		public ServerMiniGameData()
		{
		}

		// Token: 0x0400573C RID: 22332
		[Token(Token = "0x400573C")]
		[FieldOffset(Offset = "0x10")]
		public uint GameType;

		// Token: 0x0400573D RID: 22333
		[Token(Token = "0x400573D")]
		[FieldOffset(Offset = "0x14")]
		public ResourceID MarkIconRes;

		// Token: 0x0400573E RID: 22334
		[Token(Token = "0x400573E")]
		[FieldOffset(Offset = "0x18")]
		public string GameTitleKey;

		// Token: 0x0400573F RID: 22335
		[Token(Token = "0x400573F")]
		[FieldOffset(Offset = "0x20")]
		public uint RewardActivitId;

		// Token: 0x04005740 RID: 22336
		[Token(Token = "0x4005740")]
		[FieldOffset(Offset = "0x24")]
		public uint RewardItemId;

		// Token: 0x04005741 RID: 22337
		[Token(Token = "0x4005741")]
		[FieldOffset(Offset = "0x28")]
		public uint RewardItemNum;

		// Token: 0x04005742 RID: 22338
		[Token(Token = "0x4005742")]
		[FieldOffset(Offset = "0x2C")]
		public ResourceID RewardIconRes;

		// Token: 0x04005743 RID: 22339
		[Token(Token = "0x4005743")]
		[FieldOffset(Offset = "0x30")]
		public List<ResourceID> EffectResList;
	}
}
