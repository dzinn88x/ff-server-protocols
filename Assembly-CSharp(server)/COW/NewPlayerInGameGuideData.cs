using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200114B RID: 4427
	[Token(Token = "0x200114B")]
	public class NewPlayerInGameGuideData : CSVBaseData
	{
		// Token: 0x06004515 RID: 17685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004515")]
		[Address(RVA = "0x1A6352C", Offset = "0x1A6352C", VA = "0x7BBC26352C", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004516 RID: 17686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004516")]
		[Address(RVA = "0x1A63604", Offset = "0x1A63604", VA = "0x7BBC263604", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004517 RID: 17687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004517")]
		[Address(RVA = "0x1A63A04", Offset = "0x1A63A04", VA = "0x7BBC263A04")]
		public NewPlayerInGameGuideData()
		{
		}

		// Token: 0x04005581 RID: 21889
		[Token(Token = "0x4005581")]
		[FieldOffset(Offset = "0x10")]
		public TutorialEventEnum EventType;

		// Token: 0x04005582 RID: 21890
		[Token(Token = "0x4005582")]
		[FieldOffset(Offset = "0x14")]
		public TutorialUIType DisplayType;

		// Token: 0x04005583 RID: 21891
		[Token(Token = "0x4005583")]
		[FieldOffset(Offset = "0x18")]
		public float HideDelay;

		// Token: 0x04005584 RID: 21892
		[Token(Token = "0x4005584")]
		[FieldOffset(Offset = "0x20")]
		public string HintText;

		// Token: 0x04005585 RID: 21893
		[Token(Token = "0x4005585")]
		[FieldOffset(Offset = "0x28")]
		public string ParamText;

		// Token: 0x04005586 RID: 21894
		[Token(Token = "0x4005586")]
		[FieldOffset(Offset = "0x30")]
		public bool FinishWhenUserInteract;

		// Token: 0x04005587 RID: 21895
		[Token(Token = "0x4005587")]
		[FieldOffset(Offset = "0x31")]
		public bool OpenToNewBie;

		// Token: 0x04005588 RID: 21896
		[Token(Token = "0x4005588")]
		[FieldOffset(Offset = "0x32")]
		public bool CanShowInWaitingRoom;

		// Token: 0x04005589 RID: 21897
		[Token(Token = "0x4005589")]
		[FieldOffset(Offset = "0x38")]
		public List<uint> MatchMode;

		// Token: 0x0400558A RID: 21898
		[Token(Token = "0x400558A")]
		[FieldOffset(Offset = "0x40")]
		public List<uint> GameMode;

		// Token: 0x0400558B RID: 21899
		[Token(Token = "0x400558B")]
		[FieldOffset(Offset = "0x48")]
		public List<uint> GroupMode;

		// Token: 0x0400558C RID: 21900
		[Token(Token = "0x400558C")]
		[FieldOffset(Offset = "0x50")]
		public bool ShowToVeteran;

		// Token: 0x0400558D RID: 21901
		[Token(Token = "0x400558D")]
		[FieldOffset(Offset = "0x51")]
		public bool ShowEveryLauncher;
	}
}
