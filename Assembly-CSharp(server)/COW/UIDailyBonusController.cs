using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001780 RID: 6016
	[Token(Token = "0x2001780")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F2294", Offset = "0x10F2294")]
	public class UIDailyBonusController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06007223 RID: 29219 RVA: 0x0001FC68 File Offset: 0x0001DE68
		[Token(Token = "0x6007223")]
		[Address(RVA = "0x1BAC1A8", Offset = "0x1BAC1A8", VA = "0x7BBC3AC1A8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007224 RID: 29220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007224")]
		[Address(RVA = "0x1BAC1F8", Offset = "0x1BAC1F8", VA = "0x7BBC3AC1F8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007225 RID: 29221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007225")]
		[Address(RVA = "0x1BAC4E8", Offset = "0x1BAC4E8", VA = "0x7BBC3AC4E8", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06007226 RID: 29222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007226")]
		[Address(RVA = "0x1BAC59C", Offset = "0x1BAC59C", VA = "0x7BBC3AC59C")]
		private void OnTipsClicked()
		{
		}

		// Token: 0x06007227 RID: 29223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007227")]
		[Address(RVA = "0x1BACA58", Offset = "0x1BACA58", VA = "0x7BBC3ACA58")]
		private void ShowTips()
		{
		}

		// Token: 0x06007228 RID: 29224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007228")]
		[Address(RVA = "0x1BACB5C", Offset = "0x1BACB5C", VA = "0x7BBC3ACB5C", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06007229 RID: 29225 RVA: 0x0001FC80 File Offset: 0x0001DE80
		[Token(Token = "0x6007229")]
		[Address(RVA = "0x1BACDB8", Offset = "0x1BACDB8", VA = "0x7BBC3ACDB8", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600722A RID: 29226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600722A")]
		[Address(RVA = "0x1BACBD4", Offset = "0x1BACBD4", VA = "0x7BBC3ACBD4")]
		private void RefreshDailyBonusState()
		{
		}

		// Token: 0x0600722B RID: 29227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600722B")]
		[Address(RVA = "0x1BACDFC", Offset = "0x1BACDFC", VA = "0x7BBC3ACDFC")]
		public UIDailyBonusController()
		{
		}

		// Token: 0x04008B52 RID: 35666
		[Token(Token = "0x4008B52")]
		[FieldOffset(Offset = "0x58")]
		private UIDailyBonusView m_View;

		// Token: 0x04008B53 RID: 35667
		[Token(Token = "0x4008B53")]
		[FieldOffset(Offset = "0x60")]
		private List<string> m_Data;
	}
}
