using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200059D RID: 1437
	[Token(Token = "0x200059D")]
	[ProtoContract]
	public class EGroup
	{
		// Token: 0x06002349 RID: 9033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002349")]
		[Address(RVA = "0x21B9820", Offset = "0x21B9820", VA = "0x7BBC9B9820")]
		public EGroup()
		{
		}

		// Token: 0x0200059E RID: 1438
		[Token(Token = "0x200059E")]
		[ProtoContract]
		public enum StatusChangeReason
		{
			// Token: 0x04001C81 RID: 7297
			[Token(Token = "0x4001C81")]
			StatusChangeReason_NONE,
			// Token: 0x04001C82 RID: 7298
			[Token(Token = "0x4001C82")]
			StatusChangeReason_STARTMATCH,
			// Token: 0x04001C83 RID: 7299
			[Token(Token = "0x4001C83")]
			StatusChangeReason_ENDMATCH,
			// Token: 0x04001C84 RID: 7300
			[Token(Token = "0x4001C84")]
			StatusChangeReason_DROPMATCH,
			// Token: 0x04001C85 RID: 7301
			[Token(Token = "0x4001C85")]
			StatusChangeReason_MATCHMAKINGTIMEOUT,
			// Token: 0x04001C86 RID: 7302
			[Token(Token = "0x4001C86")]
			StatusChangeReason_JOINROOM,
			// Token: 0x04001C87 RID: 7303
			[Token(Token = "0x4001C87")]
			StatusChangeReason_EMULATOR
		}

		// Token: 0x0200059F RID: 1439
		[Token(Token = "0x200059F")]
		[ProtoContract]
		public enum ChangeMatchInfoEvent
		{
			// Token: 0x04001C89 RID: 7305
			[Token(Token = "0x4001C89")]
			ChangeMatchInfoEvent_NONE,
			// Token: 0x04001C8A RID: 7306
			[Token(Token = "0x4001C8A")]
			ChangeMatchInfoEvent_ENDMATCH,
			// Token: 0x04001C8B RID: 7307
			[Token(Token = "0x4001C8B")]
			ChangeMatchInfoEvent_CHOOSELOADOUTS,
			// Token: 0x04001C8C RID: 7308
			[Token(Token = "0x4001C8C")]
			ChangeMatchInfoEvent_CHOOSEPVEWEAPON,
			// Token: 0x04001C8D RID: 7309
			[Token(Token = "0x4001C8D")]
			ChangeMatchInfoEvent_CHOOSEEMOTE,
			// Token: 0x04001C8E RID: 7310
			[Token(Token = "0x4001C8E")]
			ChangeMatchInfoEvent_ANTIADDICTIONBAN,
			// Token: 0x04001C8F RID: 7311
			[Token(Token = "0x4001C8F")]
			ChangeMatchInfoEvent_CHOOSECLOTHES,
			// Token: 0x04001C90 RID: 7312
			[Token(Token = "0x4001C90")]
			ChangeMatchInfoEvent_ACCOUNTHACKERTAG,
			// Token: 0x04001C91 RID: 7313
			[Token(Token = "0x4001C91")]
			ChangeMatchInfoEvent_EQUIPSKILLS
		}
	}
}
