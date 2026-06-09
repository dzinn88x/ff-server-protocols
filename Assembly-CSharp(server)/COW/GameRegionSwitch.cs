using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020011BB RID: 4539
	[Token(Token = "0x20011BB")]
	public class GameRegionSwitch : SingletonModule<GameRegionSwitch>
	{
		// Token: 0x06004694 RID: 18068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004694")]
		[Address(RVA = "0x1B6CA08", Offset = "0x1B6CA08", VA = "0x7BBC36CA08", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x06004695 RID: 18069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004695")]
		[Address(RVA = "0x1B6CA68", Offset = "0x1B6CA68", VA = "0x7BBC36CA68", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x06004696 RID: 18070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004696")]
		[Address(RVA = "0x1B6CA6C", Offset = "0x1B6CA6C", VA = "0x7BBC36CA6C")]
		public void RequestRegionSwith(uint httpOption)
		{
		}

		// Token: 0x06004697 RID: 18071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004697")]
		[Address(RVA = "0x1B6CBEC", Offset = "0x1B6CBEC", VA = "0x7BBC36CBEC")]
		public void ProcessRegionSwitch(CSGetAllSwitchsRes switchsRes)
		{
		}

		// Token: 0x06004698 RID: 18072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004698")]
		[Address(RVA = "0x1B6CF70", Offset = "0x1B6CF70", VA = "0x7BBC36CF70")]
		public SwitchDesc GetSwitchDesc(ESwitch.SwitchFunc func)
		{
			return null;
		}

		// Token: 0x06004699 RID: 18073 RVA: 0x00015438 File Offset: 0x00013638
		[Token(Token = "0x6004699")]
		[Address(RVA = "0x1B6D018", Offset = "0x1B6D018", VA = "0x7BBC36D018")]
		public bool IsGiftStoreShow()
		{
			return default(bool);
		}

		// Token: 0x0600469A RID: 18074 RVA: 0x00015450 File Offset: 0x00013650
		[Token(Token = "0x600469A")]
		[Address(RVA = "0x1B6D048", Offset = "0x1B6D048", VA = "0x7BBC36D048")]
		public bool IsCatapultEnable()
		{
			return default(bool);
		}

		// Token: 0x0600469B RID: 18075 RVA: 0x00015468 File Offset: 0x00013668
		[Token(Token = "0x600469B")]
		[Address(RVA = "0x1B6CEBC", Offset = "0x1B6CEBC", VA = "0x7BBC36CEBC")]
		public bool IsOpen(ESwitch.SwitchFunc switchfunc, bool defaultValue = false)
		{
			return default(bool);
		}

		// Token: 0x0600469C RID: 18076 RVA: 0x00015480 File Offset: 0x00013680
		[Token(Token = "0x600469C")]
		[Address(RVA = "0x1B6D078", Offset = "0x1B6D078", VA = "0x7BBC36D078")]
		public bool IsGachaEntranceOpen()
		{
			return default(bool);
		}

		// Token: 0x0600469D RID: 18077 RVA: 0x00015498 File Offset: 0x00013698
		[Token(Token = "0x600469D")]
		[Address(RVA = "0x1B6D0A8", Offset = "0x1B6D0A8", VA = "0x7BBC36D0A8")]
		public bool IsShareButtonOpen()
		{
			return default(bool);
		}

		// Token: 0x0600469E RID: 18078 RVA: 0x000154B0 File Offset: 0x000136B0
		[Token(Token = "0x600469E")]
		[Address(RVA = "0x1B6D0D8", Offset = "0x1B6D0D8", VA = "0x7BBC36D0D8")]
		public bool IsSignATureFuncOpen()
		{
			return default(bool);
		}

		// Token: 0x0600469F RID: 18079 RVA: 0x000154C8 File Offset: 0x000136C8
		[Token(Token = "0x600469F")]
		[Address(RVA = "0x1B6D108", Offset = "0x1B6D108", VA = "0x7BBC36D108")]
		public bool IsBroadcastAutoFetchFuncOpen()
		{
			return default(bool);
		}

		// Token: 0x060046A0 RID: 18080 RVA: 0x000154E0 File Offset: 0x000136E0
		[Token(Token = "0x60046A0")]
		[Address(RVA = "0x1B6D138", Offset = "0x1B6D138", VA = "0x7BBC36D138")]
		public bool IsFriendRelationshipFuncOpen()
		{
			return default(bool);
		}

		// Token: 0x060046A1 RID: 18081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046A1")]
		[Address(RVA = "0x1B6D168", Offset = "0x1B6D168", VA = "0x7BBC36D168")]
		public GameRegionSwitch()
		{
		}

		// Token: 0x060046A2 RID: 18082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046A2")]
		[Address(RVA = "0x1B6D200", Offset = "0x1B6D200", VA = "0x7BBC36D200")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DA78", Offset = "0x113DA78")]
		private void <RequestRegionSwith>b__4_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x04005D7C RID: 23932
		[Token(Token = "0x4005D7C")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<ESwitch.SwitchFunc, SwitchDesc> m_Switchs;

		// Token: 0x04005D7D RID: 23933
		[Token(Token = "0x4005D7D")]
		[FieldOffset(Offset = "0x20")]
		public bool Initalized;
	}
}
