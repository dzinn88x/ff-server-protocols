using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using message;
using proto;

namespace COW
{
	// Token: 0x02001EB5 RID: 7861
	[Token(Token = "0x2001EB5")]
	public class UIModelGameBonusEvent : UIBaseModel
	{
		// Token: 0x0600AC53 RID: 44115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC53")]
		[Address(RVA = "0x23202F4", Offset = "0x23202F4", VA = "0x7BBCB202F4", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600AC54 RID: 44116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC54")]
		[Address(RVA = "0x2320374", Offset = "0x2320374", VA = "0x7BBCB20374")]
		public void ProcessDescData(CSGetGameBonusEventDescRes desc)
		{
		}

		// Token: 0x0600AC55 RID: 44117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC55")]
		[Address(RVA = "0x232037C", Offset = "0x232037C", VA = "0x7BBCB2037C")]
		public void RequestGameBonusEventDesc(bool force = false)
		{
		}

		// Token: 0x0600AC56 RID: 44118 RVA: 0x0002F8F8 File Offset: 0x0002DAF8
		[Token(Token = "0x600AC56")]
		[Address(RVA = "0x232057C", Offset = "0x232057C", VA = "0x7BBCB2057C")]
		public bool IsInDoubleBonusPeriod(uint matchMode, uint gameMode, uint mapID, zTfbhtW groupMode, out GameBonusEventDesc eventDesc, out ulong startTime, out ulong endTime)
		{
			return default(bool);
		}

		// Token: 0x0600AC57 RID: 44119 RVA: 0x0002F910 File Offset: 0x0002DB10
		[Token(Token = "0x600AC57")]
		[Address(RVA = "0x23208E0", Offset = "0x23208E0", VA = "0x7BBCB208E0")]
		public bool IsConditionMatch(GameBonusEventDesc desc, uint matchMode, uint gameMode, uint mapID, zTfbhtW groupMode)
		{
			return default(bool);
		}

		// Token: 0x0600AC58 RID: 44120 RVA: 0x0002F928 File Offset: 0x0002DB28
		[Token(Token = "0x600AC58")]
		[Address(RVA = "0x232099C", Offset = "0x232099C", VA = "0x7BBCB2099C", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600AC59 RID: 44121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC59")]
		[Address(RVA = "0x23209A4", Offset = "0x23209A4", VA = "0x7BBCB209A4")]
		public UIModelGameBonusEvent()
		{
		}

		// Token: 0x0600AC5A RID: 44122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC5A")]
		[Address(RVA = "0x2320A34", Offset = "0x2320A34", VA = "0x7BBCB20A34")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114637C", Offset = "0x114637C")]
		private void <RequestGameBonusEventDesc>b__9_0(HttpErrorCode err, object res)
		{
		}

		// Token: 0x0400B0EC RID: 45292
		[Token(Token = "0x400B0EC")]
		[FieldOffset(Offset = "0x18")]
		private CSGetGameBonusEventDescRes m_Desc;

		// Token: 0x0400B0ED RID: 45293
		[Token(Token = "0x400B0ED")]
		private const int AllGroupMode = -1;

		// Token: 0x0400B0EE RID: 45294
		[Token(Token = "0x400B0EE")]
		private const int AllGameMode = 0;

		// Token: 0x0400B0EF RID: 45295
		[Token(Token = "0x400B0EF")]
		private const int AllMatchMode = 0;

		// Token: 0x0400B0F0 RID: 45296
		[Token(Token = "0x400B0F0")]
		private const int AllMapID = 0;

		// Token: 0x0400B0F1 RID: 45297
		[Token(Token = "0x400B0F1")]
		[FieldOffset(Offset = "0x20")]
		private List<ServiceMessageTypeHTTP> m_RequestQueue;

		// Token: 0x0400B0F2 RID: 45298
		[Token(Token = "0x400B0F2")]
		public const int PropID_BonusEventDescRespond = 2;

		// Token: 0x02001EB6 RID: 7862
		[Token(Token = "0x2001EB6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCAB4", Offset = "0x10FCAB4")]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x0600AC5B RID: 44123 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AC5B")]
			[Address(RVA = "0x23208D8", Offset = "0x23208D8", VA = "0x7BBCB208D8")]
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x0600AC5C RID: 44124 RVA: 0x0002F940 File Offset: 0x0002DB40
			[Token(Token = "0x600AC5C")]
			[Address(RVA = "0x2320B18", Offset = "0x2320B18", VA = "0x7BBCB20B18")]
			internal bool <IsInDoubleBonusPeriod>b__0(GameBonusEventDesc e)
			{
				return default(bool);
			}

			// Token: 0x0400B0F3 RID: 45299
			[Token(Token = "0x400B0F3")]
			[FieldOffset(Offset = "0x10")]
			public UIModelGameBonusEvent <>4__this;

			// Token: 0x0400B0F4 RID: 45300
			[Token(Token = "0x400B0F4")]
			[FieldOffset(Offset = "0x18")]
			public uint matchMode;

			// Token: 0x0400B0F5 RID: 45301
			[Token(Token = "0x400B0F5")]
			[FieldOffset(Offset = "0x1C")]
			public uint gameMode;

			// Token: 0x0400B0F6 RID: 45302
			[Token(Token = "0x400B0F6")]
			[FieldOffset(Offset = "0x20")]
			public uint mapID;

			// Token: 0x0400B0F7 RID: 45303
			[Token(Token = "0x400B0F7")]
			[FieldOffset(Offset = "0x24")]
			public zTfbhtW groupMode;
		}
	}
}
