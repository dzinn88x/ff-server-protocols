using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x0200179B RID: 6043
	[Token(Token = "0x200179B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F264C", Offset = "0x10F264C")]
	public class UIElitePassPreorderController : UINavigationController
	{
		// Token: 0x06007348 RID: 29512 RVA: 0x00020088 File Offset: 0x0001E288
		[Token(Token = "0x6007348")]
		[Address(RVA = "0x1E67BC0", Offset = "0x1E67BC0", VA = "0x7BBC667BC0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007349 RID: 29513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007349")]
		[Address(RVA = "0x1E67C10", Offset = "0x1E67C10", VA = "0x7BBC667C10", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600734A RID: 29514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600734A")]
		[Address(RVA = "0x1E685EC", Offset = "0x1E685EC", VA = "0x7BBC6685EC")]
		private void UpdatePreviewItems()
		{
		}

		// Token: 0x0600734B RID: 29515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600734B")]
		[Address(RVA = "0x1E67EC4", Offset = "0x1E67EC4", VA = "0x7BBC667EC4")]
		private void UpdatePreorderUI()
		{
		}

		// Token: 0x0600734C RID: 29516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600734C")]
		[Address(RVA = "0x1E68420", Offset = "0x1E68420", VA = "0x7BBC668420")]
		private void UpdateSubscriptionUI()
		{
		}

		// Token: 0x0600734D RID: 29517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600734D")]
		[Address(RVA = "0x1E68808", Offset = "0x1E68808", VA = "0x7BBC668808")]
		private void UpdateFullScreenCG()
		{
		}

		// Token: 0x0600734E RID: 29518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600734E")]
		[Address(RVA = "0x1E68B50", Offset = "0x1E68B50", VA = "0x7BBC668B50")]
		private void OnClickAnimPlayBtn()
		{
		}

		// Token: 0x0600734F RID: 29519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600734F")]
		[Address(RVA = "0x1E68B54", Offset = "0x1E68B54", VA = "0x7BBC668B54")]
		private void ShowFullScreenCG()
		{
		}

		// Token: 0x06007350 RID: 29520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007350")]
		[Address(RVA = "0x1E68A40", Offset = "0x1E68A40", VA = "0x7BBC668A40")]
		private void AutoShowCG()
		{
		}

		// Token: 0x06007351 RID: 29521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007351")]
		[Address(RVA = "0x1E68CB8", Offset = "0x1E68CB8", VA = "0x7BBC668CB8")]
		private void OnPreorderSuccess(object[] data)
		{
		}

		// Token: 0x06007352 RID: 29522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007352")]
		[Address(RVA = "0x1E690F4", Offset = "0x1E690F4", VA = "0x7BBC6690F4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007353 RID: 29523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007353")]
		[Address(RVA = "0x1E691C0", Offset = "0x1E691C0", VA = "0x7BBC6691C0")]
		private void OnPreorderBtnClick()
		{
		}

		// Token: 0x06007354 RID: 29524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007354")]
		[Address(RVA = "0x1E693D0", Offset = "0x1E693D0", VA = "0x7BBC6693D0")]
		private void PreorderEP()
		{
		}

		// Token: 0x06007355 RID: 29525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007355")]
		[Address(RVA = "0x1E694E8", Offset = "0x1E694E8", VA = "0x7BBC6694E8")]
		private void OnSubscribeBtnClick()
		{
		}

		// Token: 0x06007356 RID: 29526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007356")]
		[Address(RVA = "0x1E69564", Offset = "0x1E69564", VA = "0x7BBC669564")]
		public UIElitePassPreorderController()
		{
		}

		// Token: 0x04008BD7 RID: 35799
		[Token(Token = "0x4008BD7")]
		[FieldOffset(Offset = "0xB0")]
		private UIElitePassPreorderView m_View;

		// Token: 0x04008BD8 RID: 35800
		[Token(Token = "0x4008BD8")]
		[FieldOffset(Offset = "0xB8")]
		private UIModelElitePass m_Model;

		// Token: 0x04008BD9 RID: 35801
		[Token(Token = "0x4008BD9")]
		[FieldOffset(Offset = "0xC0")]
		private EPPreorderData m_Data;

		// Token: 0x04008BDA RID: 35802
		[Token(Token = "0x4008BDA")]
		[FieldOffset(Offset = "0xC8")]
		private FullscreenCgDesc m_FullScreenCG;

		// Token: 0x0200179C RID: 6044
		[Token(Token = "0x200179C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F2684", Offset = "0x10F2684")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06007358 RID: 29528 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007358")]
			[Address(RVA = "0x1E695D0", Offset = "0x1E695D0", VA = "0x7BBC6695D0")]
			public <>c()
			{
			}

			// Token: 0x06007359 RID: 29529 RVA: 0x000200A0 File Offset: 0x0001E2A0
			[Token(Token = "0x6007359")]
			[Address(RVA = "0x1E695D8", Offset = "0x1E695D8", VA = "0x7BBC6695D8")]
			internal bool <UpdatePreorderUI>b__7_0(AdvertDesc x)
			{
				return default(bool);
			}

			// Token: 0x0600735A RID: 29530 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600735A")]
			[Address(RVA = "0x1E6960C", Offset = "0x1E6960C", VA = "0x7BBC66960C")]
			internal void <OnPreorderSuccess>b__13_0()
			{
			}

			// Token: 0x04008BDB RID: 35803
			[Token(Token = "0x4008BDB")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIElitePassPreorderController.<>c <>9;

			// Token: 0x04008BDC RID: 35804
			[Token(Token = "0x4008BDC")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<AdvertDesc> <>9__7_0;

			// Token: 0x04008BDD RID: 35805
			[Token(Token = "0x4008BDD")]
			[FieldOffset(Offset = "0x10")]
			public static Action <>9__13_0;
		}
	}
}
