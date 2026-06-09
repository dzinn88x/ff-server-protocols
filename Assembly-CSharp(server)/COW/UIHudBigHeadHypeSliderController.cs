using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200187A RID: 6266
	[Token(Token = "0x200187A")]
	public class UIHudBigHeadHypeSliderController : UIHudHypeSliderController
	{
		// Token: 0x06007BD9 RID: 31705 RVA: 0x00022098 File Offset: 0x00020298
		[Token(Token = "0x6007BD9")]
		[Address(RVA = "0x1893E70", Offset = "0x1893E70", VA = "0x7BBC093E70")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007BDA RID: 31706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BDA")]
		[Address(RVA = "0x1893EC0", Offset = "0x1893EC0", VA = "0x7BBC093EC0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007BDB RID: 31707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BDB")]
		[Address(RVA = "0x1893FA0", Offset = "0x1893FA0", VA = "0x7BBC093FA0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007BDC RID: 31708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BDC")]
		[Address(RVA = "0x1894078", Offset = "0x1894078", VA = "0x7BBC094078", Slot = "28")]
		protected override void OnHypeLevelChange(object[] data)
		{
		}

		// Token: 0x06007BDD RID: 31709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BDD")]
		[Address(RVA = "0x1894180", Offset = "0x1894180", VA = "0x7BBC094180")]
		public UIHudBigHeadHypeSliderController()
		{
		}

		// Token: 0x04009024 RID: 36900
		[Token(Token = "0x4009024")]
		[FieldOffset(Offset = "0x90")]
		private UIHudBigHeadHypeProcessBarView m_BigHeadView;

		// Token: 0x04009025 RID: 36901
		[Token(Token = "0x4009025")]
		[FieldOffset(Offset = "0x98")]
		private bool m_TutShowed;
	}
}
