using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001966 RID: 6502
	[Token(Token = "0x2001966")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F630C", Offset = "0x10F630C")]
	internal class UIHudSuicideController : UIBaseController
	{
		// Token: 0x0600843A RID: 33850 RVA: 0x00023E50 File Offset: 0x00022050
		[Token(Token = "0x600843A")]
		[Address(RVA = "0x16746C8", Offset = "0x16746C8", VA = "0x7BBBE746C8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600843B RID: 33851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600843B")]
		[Address(RVA = "0x1674718", Offset = "0x1674718", VA = "0x7BBBE74718", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600843C RID: 33852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600843C")]
		[Address(RVA = "0x1674988", Offset = "0x1674988", VA = "0x7BBBE74988", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600843D RID: 33853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600843D")]
		[Address(RVA = "0x1674AD4", Offset = "0x1674AD4", VA = "0x7BBBE74AD4")]
		private void Update()
		{
		}

		// Token: 0x0600843E RID: 33854 RVA: 0x00023E68 File Offset: 0x00022068
		[Token(Token = "0x600843E")]
		[Address(RVA = "0x1674E28", Offset = "0x1674E28", VA = "0x7BBBE74E28")]
		public float Progress()
		{
			return 0f;
		}

		// Token: 0x0600843F RID: 33855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600843F")]
		[Address(RVA = "0x16750B4", Offset = "0x16750B4", VA = "0x7BBBE750B4")]
		private void OnBtnClick()
		{
		}

		// Token: 0x06008440 RID: 33856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008440")]
		[Address(RVA = "0x1675298", Offset = "0x1675298", VA = "0x7BBBE75298")]
		private void OnCancelBtnClick()
		{
		}

		// Token: 0x06008441 RID: 33857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008441")]
		[Address(RVA = "0x167529C", Offset = "0x167529C", VA = "0x7BBBE7529C")]
		private void OnPreparationCancel(params object[] param)
		{
		}

		// Token: 0x06008442 RID: 33858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008442")]
		[Address(RVA = "0x1674F4C", Offset = "0x1674F4C", VA = "0x7BBBE74F4C")]
		private void OnExecuteSuicide()
		{
		}

		// Token: 0x06008443 RID: 33859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008443")]
		[Address(RVA = "0x16748DC", Offset = "0x16748DC", VA = "0x7BBBE748DC")]
		private void ResetStatus()
		{
		}

		// Token: 0x06008444 RID: 33860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008444")]
		[Address(RVA = "0x16752A0", Offset = "0x16752A0", VA = "0x7BBBE752A0")]
		public UIHudSuicideController()
		{
		}

		// Token: 0x040094A8 RID: 38056
		[Token(Token = "0x40094A8")]
		[FieldOffset(Offset = "0x58")]
		private UIHudSuicideView m_View;

		// Token: 0x040094A9 RID: 38057
		[Token(Token = "0x40094A9")]
		[FieldOffset(Offset = "0x60")]
		private float m_SuicideEndTime;
	}
}
