using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020013B7 RID: 5047
	[Token(Token = "0x20013B7")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EBBC8", Offset = "0x10EBBC8")]
	public class UISuperCarDailyWndController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x0600523F RID: 21055 RVA: 0x00018B88 File Offset: 0x00016D88
		[Token(Token = "0x600523F")]
		[Address(RVA = "0x2142FE0", Offset = "0x2142FE0", VA = "0x7BBC942FE0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005240 RID: 21056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005240")]
		[Address(RVA = "0x2143030", Offset = "0x2143030", VA = "0x7BBC943030", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005241 RID: 21057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005241")]
		[Address(RVA = "0x2140518", Offset = "0x2140518", VA = "0x7BBC940518")]
		public void SetData(List<ClientActivityDesc> descs)
		{
		}

		// Token: 0x06005242 RID: 21058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005242")]
		[Address(RVA = "0x2143100", Offset = "0x2143100", VA = "0x7BBC943100", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005243 RID: 21059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005243")]
		[Address(RVA = "0x21431B4", Offset = "0x21431B4", VA = "0x7BBC9431B4", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06005244 RID: 21060 RVA: 0x00018BA0 File Offset: 0x00016DA0
		[Token(Token = "0x6005244")]
		[Address(RVA = "0x2143318", Offset = "0x2143318", VA = "0x7BBC943318", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06005245 RID: 21061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005245")]
		[Address(RVA = "0x214335C", Offset = "0x214335C", VA = "0x7BBC94335C")]
		public UISuperCarDailyWndController()
		{
		}

		// Token: 0x04007851 RID: 30801
		[Token(Token = "0x4007851")]
		[FieldOffset(Offset = "0x98")]
		private UISuperCarDailyWndView m_View;

		// Token: 0x04007852 RID: 30802
		[Token(Token = "0x4007852")]
		[FieldOffset(Offset = "0xA0")]
		private List<UISuperCarDailyItemController> m_Ctrls;
	}
}
