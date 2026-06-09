using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B44 RID: 6980
	[Token(Token = "0x2001B44")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F9944", Offset = "0x10F9944")]
	public class UIRateGamePopupWindowController : UIPopupWindowController
	{
		// Token: 0x060095E1 RID: 38369 RVA: 0x00027A08 File Offset: 0x00025C08
		[Token(Token = "0x60095E1")]
		[Address(RVA = "0x1E11008", Offset = "0x1E11008", VA = "0x7BBC611008")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060095E2 RID: 38370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095E2")]
		[Address(RVA = "0x1E11058", Offset = "0x1E11058", VA = "0x7BBC611058", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060095E3 RID: 38371 RVA: 0x00027A20 File Offset: 0x00025C20
		[Token(Token = "0x60095E3")]
		[Address(RVA = "0x1E1128C", Offset = "0x1E1128C", VA = "0x7BBC61128C", Slot = "30")]
		public override int GlassDelay()
		{
			return 0;
		}

		// Token: 0x060095E4 RID: 38372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095E4")]
		[Address(RVA = "0x1E11294", Offset = "0x1E11294", VA = "0x7BBC611294")]
		private void OnClickCloseBtn()
		{
		}

		// Token: 0x060095E5 RID: 38373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095E5")]
		[Address(RVA = "0x1E11384", Offset = "0x1E11384", VA = "0x7BBC611384")]
		private void OnClickSuggestBtn()
		{
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x060095E6 RID: 38374 RVA: 0x00027A38 File Offset: 0x00025C38
		[Token(Token = "0x17000A40")]
		private static bool UseInAppReview
		{
			[Token(Token = "0x60095E6")]
			[Address(RVA = "0x1E11850", Offset = "0x1E11850", VA = "0x7BBC611850")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060095E7 RID: 38375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095E7")]
		[Address(RVA = "0x1E1190C", Offset = "0x1E1190C", VA = "0x7BBC61190C")]
		private void OnClickPraiseBtn()
		{
		}

		// Token: 0x060095E8 RID: 38376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095E8")]
		[Address(RVA = "0x1E11A84", Offset = "0x1E11A84", VA = "0x7BBC611A84")]
		private void InAppReviewCallback(bool success)
		{
		}

		// Token: 0x060095E9 RID: 38377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095E9")]
		[Address(RVA = "0x1E11C08", Offset = "0x1E11C08", VA = "0x7BBC611C08", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060095EA RID: 38378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095EA")]
		[Address(RVA = "0x1E11C10", Offset = "0x1E11C10", VA = "0x7BBC611C10")]
		public UIRateGamePopupWindowController()
		{
		}

		// Token: 0x04009ED2 RID: 40658
		[Token(Token = "0x4009ED2")]
		[FieldOffset(Offset = "0x98")]
		private UIRateGamePopupWindowView m_View;
	}
}
