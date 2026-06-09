using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200110F RID: 4367
	[Token(Token = "0x200110F")]
	public class IngameQuickChatData : CSVBaseData
	{
		// Token: 0x06004462 RID: 17506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004462")]
		[Address(RVA = "0x185F7F8", Offset = "0x185F7F8", VA = "0x7BBC05F7F8", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004463 RID: 17507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004463")]
		[Address(RVA = "0x185F804", Offset = "0x185F804", VA = "0x7BBC05F804", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004464 RID: 17508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004464")]
		[Address(RVA = "0x185F9FC", Offset = "0x185F9FC", VA = "0x7BBC05F9FC")]
		public static List<IngameQuickChatData> GetDefaultQuickChatList(EGameModeCategory modeCategory)
		{
			return null;
		}

		// Token: 0x06004465 RID: 17509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004465")]
		[Address(RVA = "0x185FBB0", Offset = "0x185FBB0", VA = "0x7BBC05FBB0")]
		public IngameQuickChatData()
		{
		}

		// Token: 0x04005454 RID: 21588
		[Token(Token = "0x4005454")]
		[FieldOffset(Offset = "0x10")]
		public uint m_ID;

		// Token: 0x04005455 RID: 21589
		[Token(Token = "0x4005455")]
		[FieldOffset(Offset = "0x18")]
		public string m_MessageKey;

		// Token: 0x04005456 RID: 21590
		[Token(Token = "0x4005456")]
		[FieldOffset(Offset = "0x20")]
		public ResourceID m_SoundID;

		// Token: 0x04005457 RID: 21591
		[Token(Token = "0x4005457")]
		[FieldOffset(Offset = "0x24")]
		public EGameModeCategory m_ModeCategory;

		// Token: 0x04005458 RID: 21592
		[Token(Token = "0x4005458")]
		[FieldOffset(Offset = "0x28")]
		public bool m_IsDefault;
	}
}
