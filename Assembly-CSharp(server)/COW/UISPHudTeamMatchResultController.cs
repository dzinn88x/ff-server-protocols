using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B9B RID: 7067
	[Token(Token = "0x2001B9B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FA7CC", Offset = "0x10FA7CC")]
	public class UISPHudTeamMatchResultController : UIBaseController
	{
		// Token: 0x0600987C RID: 39036 RVA: 0x00028290 File Offset: 0x00026490
		[Token(Token = "0x600987C")]
		[Address(RVA = "0x1EF70A0", Offset = "0x1EF70A0", VA = "0x7BBC6F70A0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600987D RID: 39037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600987D")]
		[Address(RVA = "0x1EF70F0", Offset = "0x1EF70F0", VA = "0x7BBC6F70F0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600987E RID: 39038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600987E")]
		[Address(RVA = "0x1EF7A00", Offset = "0x1EF7A00", VA = "0x7BBC6F7A00", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600987F RID: 39039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600987F")]
		[Address(RVA = "0x1EF7B20", Offset = "0x1EF7B20", VA = "0x7BBC6F7B20")]
		private void OnNextBtnClick()
		{
		}

		// Token: 0x06009880 RID: 39040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009880")]
		[Address(RVA = "0x1EF7BF0", Offset = "0x1EF7BF0", VA = "0x7BBC6F7BF0")]
		private void OnDetailBtnClick()
		{
		}

		// Token: 0x06009881 RID: 39041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009881")]
		[Address(RVA = "0x1EF7CC0", Offset = "0x1EF7CC0", VA = "0x7BBC6F7CC0")]
		private void OnBackBtnClick()
		{
		}

		// Token: 0x06009882 RID: 39042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009882")]
		[Address(RVA = "0x1EF7DE0", Offset = "0x1EF7DE0", VA = "0x7BBC6F7DE0")]
		private void DetailBtnTriggered(params object[] data)
		{
		}

		// Token: 0x06009883 RID: 39043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009883")]
		[Address(RVA = "0x1EF7DE4", Offset = "0x1EF7DE4", VA = "0x7BBC6F7DE4")]
		private void NextBtnTriggered(params object[] data)
		{
		}

		// Token: 0x06009884 RID: 39044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009884")]
		[Address(RVA = "0x1EF74AC", Offset = "0x1EF74AC", VA = "0x7BBC6F74AC")]
		private void RefreshUI()
		{
		}

		// Token: 0x06009885 RID: 39045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009885")]
		[Address(RVA = "0x1EF7DE8", Offset = "0x1EF7DE8", VA = "0x7BBC6F7DE8")]
		private void SetTop1View(ResultTeamData res)
		{
		}

		// Token: 0x06009886 RID: 39046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009886")]
		[Address(RVA = "0x1EF809C", Offset = "0x1EF809C", VA = "0x7BBC6F809C")]
		private void SetTop2View(ResultTeamData res)
		{
		}

		// Token: 0x06009887 RID: 39047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009887")]
		[Address(RVA = "0x1EF8350", Offset = "0x1EF8350", VA = "0x7BBC6F8350")]
		private void SetTop3View(ResultTeamData res)
		{
		}

		// Token: 0x06009888 RID: 39048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009888")]
		[Address(RVA = "0x1EF8604", Offset = "0x1EF8604", VA = "0x7BBC6F8604")]
		public UISPHudTeamMatchResultController()
		{
		}

		// Token: 0x0400A039 RID: 41017
		[Token(Token = "0x400A039")]
		[FieldOffset(Offset = "0x58")]
		private UISPHudTeamMatchResultView m_View;
	}
}
