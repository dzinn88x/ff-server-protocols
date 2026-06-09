using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001887 RID: 6279
	[Token(Token = "0x2001887")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F447C", Offset = "0x10F447C")]
	internal class UIHudBuffListController : UIBaseController
	{
		// Token: 0x06007C46 RID: 31814 RVA: 0x00022278 File Offset: 0x00020478
		[Token(Token = "0x6007C46")]
		[Address(RVA = "0x189F38C", Offset = "0x189F38C", VA = "0x7BBC09F38C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007C47 RID: 31815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C47")]
		[Address(RVA = "0x189F3DC", Offset = "0x189F3DC", VA = "0x7BBC09F3DC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007C48 RID: 31816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C48")]
		[Address(RVA = "0x189F538", Offset = "0x189F538", VA = "0x7BBC09F538", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06007C49 RID: 31817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C49")]
		[Address(RVA = "0x189F540", Offset = "0x189F540", VA = "0x7BBC09F540")]
		protected void OnBuffBehaviorChanged(params object[] param)
		{
		}

		// Token: 0x06007C4A RID: 31818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C4A")]
		[Address(RVA = "0x189FF50", Offset = "0x189FF50", VA = "0x7BBC09FF50", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007C4B RID: 31819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C4B")]
		[Address(RVA = "0x189FA98", Offset = "0x189FA98", VA = "0x7BBC09FA98")]
		private void RefreshUI()
		{
		}

		// Token: 0x06007C4C RID: 31820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C4C")]
		[Address(RVA = "0x18A00D8", Offset = "0x18A00D8", VA = "0x7BBC0A00D8")]
		public UIHudBuffListController()
		{
		}

		// Token: 0x04009053 RID: 36947
		[Token(Token = "0x4009053")]
		[FieldOffset(Offset = "0x58")]
		private UIHudBuffListView m_View;

		// Token: 0x04009054 RID: 36948
		[Token(Token = "0x4009054")]
		[FieldOffset(Offset = "0x60")]
		private List<SIljDGq> m_CurrentBuffBehaivorList;

		// Token: 0x04009055 RID: 36949
		[Token(Token = "0x4009055")]
		[FieldOffset(Offset = "0x68")]
		private List<UIHudBuffListItemController> m_ItemControllers;

		// Token: 0x02001888 RID: 6280
		[Token(Token = "0x2001888")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F44B4", Offset = "0x10F44B4")]
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x06007C4D RID: 31821 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C4D")]
			[Address(RVA = "0x189FA90", Offset = "0x189FA90", VA = "0x7BBC09FA90")]
			public <>c__DisplayClass6_0()
			{
			}

			// Token: 0x06007C4E RID: 31822 RVA: 0x00022290 File Offset: 0x00020490
			[Token(Token = "0x6007C4E")]
			[Address(RVA = "0x18A00E0", Offset = "0x18A00E0", VA = "0x7BBC0A00E0")]
			internal bool <OnBuffBehaviorChanged>b__0(SIljDGq temp)
			{
				return default(bool);
			}

			// Token: 0x06007C4F RID: 31823 RVA: 0x000222A8 File Offset: 0x000204A8
			[Token(Token = "0x6007C4F")]
			[Address(RVA = "0x18A012C", Offset = "0x18A012C", VA = "0x7BBC0A012C")]
			internal bool <OnBuffBehaviorChanged>b__1(SIljDGq temp)
			{
				return default(bool);
			}

			// Token: 0x06007C50 RID: 31824 RVA: 0x000222C0 File Offset: 0x000204C0
			[Token(Token = "0x6007C50")]
			[Address(RVA = "0x18A0178", Offset = "0x18A0178", VA = "0x7BBC0A0178")]
			internal bool <OnBuffBehaviorChanged>b__2(SIljDGq temp)
			{
				return default(bool);
			}

			// Token: 0x04009056 RID: 36950
			[Token(Token = "0x4009056")]
			[FieldOffset(Offset = "0x10")]
			public SIljDGq bevData;
		}
	}
}
