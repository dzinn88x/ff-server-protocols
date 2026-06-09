using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001944 RID: 6468
	[Token(Token = "0x2001944")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F5E0C", Offset = "0x10F5E0C")]
	public class UIHudRedEnvelopeButtonListController : UIBaseController
	{
		// Token: 0x0600832B RID: 33579 RVA: 0x00023A00 File Offset: 0x00021C00
		[Token(Token = "0x600832B")]
		[Address(RVA = "0x17EE380", Offset = "0x17EE380", VA = "0x7BBBFEE380")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600832C RID: 33580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600832C")]
		[Address(RVA = "0x17EE3D0", Offset = "0x17EE3D0", VA = "0x7BBBFEE3D0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600832D RID: 33581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600832D")]
		[Address(RVA = "0x17EE5A8", Offset = "0x17EE5A8", VA = "0x7BBBFEE5A8")]
		public void SetRedEnvelopeData(params object[] param)
		{
		}

		// Token: 0x0600832E RID: 33582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600832E")]
		[Address(RVA = "0x17EEB78", Offset = "0x17EEB78", VA = "0x7BBBFEEB78", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600832F RID: 33583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600832F")]
		[Address(RVA = "0x17EECEC", Offset = "0x17EECEC", VA = "0x7BBBFEECEC")]
		private void OnRedEnvelopeBtnClick(params object[] param)
		{
		}

		// Token: 0x06008330 RID: 33584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008330")]
		[Address(RVA = "0x17EEF40", Offset = "0x17EEF40", VA = "0x7BBBFEEF40")]
		private void OnTrainingZoneChanged(params object[] param)
		{
		}

		// Token: 0x06008331 RID: 33585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008331")]
		[Address(RVA = "0x17EEFEC", Offset = "0x17EEFEC", VA = "0x7BBBFEEFEC")]
		public UIHudRedEnvelopeButtonListController()
		{
		}

		// Token: 0x04009423 RID: 37923
		[Token(Token = "0x4009423")]
		[FieldOffset(Offset = "0x58")]
		private UIHudRedEnvelopeButtonListView m_View;

		// Token: 0x04009424 RID: 37924
		[Token(Token = "0x4009424")]
		[FieldOffset(Offset = "0x60")]
		private List<RedEnvelopeItemView> m_ItemViewList;

		// Token: 0x02001945 RID: 6469
		[Token(Token = "0x2001945")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F5E44", Offset = "0x10F5E44")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06008333 RID: 33587 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008333")]
			[Address(RVA = "0x17EF0C0", Offset = "0x17EF0C0", VA = "0x7BBBFEF0C0")]
			public <>c()
			{
			}

			// Token: 0x06008334 RID: 33588 RVA: 0x00023A18 File Offset: 0x00021C18
			[Token(Token = "0x6008334")]
			[Address(RVA = "0x17EF0C8", Offset = "0x17EF0C8", VA = "0x7BBBFEF0C8")]
			internal int <SetRedEnvelopeData>b__4_0(nQJxQBO a, nQJxQBO b)
			{
				return 0;
			}

			// Token: 0x04009425 RID: 37925
			[Token(Token = "0x4009425")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIHudRedEnvelopeButtonListController.<>c <>9;

			// Token: 0x04009426 RID: 37926
			[Token(Token = "0x4009426")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<nQJxQBO> <>9__4_0;
		}
	}
}
