using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200141F RID: 5151
	[Token(Token = "0x200141F")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EC768", Offset = "0x10EC768")]
	public class UIHudArmsListController : UIBaseController
	{
		// Token: 0x060054F7 RID: 21751 RVA: 0x000195C0 File Offset: 0x000177C0
		[Token(Token = "0x60054F7")]
		[Address(RVA = "0x1884D04", Offset = "0x1884D04", VA = "0x7BBC084D04")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060054F8 RID: 21752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054F8")]
		[Address(RVA = "0x1884D54", Offset = "0x1884D54", VA = "0x7BBC084D54", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060054F9 RID: 21753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054F9")]
		[Address(RVA = "0x1885098", Offset = "0x1885098", VA = "0x7BBC085098")]
		public void SetUIData(List<YmQ\u0082E\u007FN> armsInfoList)
		{
		}

		// Token: 0x060054FA RID: 21754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054FA")]
		[Address(RVA = "0x18852C4", Offset = "0x18852C4", VA = "0x7BBC0852C4")]
		private void OnGridReposition()
		{
		}

		// Token: 0x060054FB RID: 21755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054FB")]
		[Address(RVA = "0x18855C8", Offset = "0x18855C8", VA = "0x7BBC0855C8")]
		private void OnConfirmBtnClick()
		{
		}

		// Token: 0x060054FC RID: 21756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054FC")]
		[Address(RVA = "0x1884FD0", Offset = "0x1884FD0", VA = "0x7BBC084FD0")]
		private void StartDelayCall()
		{
		}

		// Token: 0x060054FD RID: 21757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054FD")]
		[Address(RVA = "0x18855D0", Offset = "0x18855D0", VA = "0x7BBC0855D0", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x060054FE RID: 21758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054FE")]
		[Address(RVA = "0x188567C", Offset = "0x188567C", VA = "0x7BBC08567C")]
		public UIHudArmsListController()
		{
		}

		// Token: 0x060054FF RID: 21759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054FF")]
		[Address(RVA = "0x1885714", Offset = "0x1885714", VA = "0x7BBC085714")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113E82C", Offset = "0x113E82C")]
		private void <StartDelayCall>b__10_0()
		{
		}

		// Token: 0x04007A24 RID: 31268
		[Token(Token = "0x4007A24")]
		[FieldOffset(Offset = "0x58")]
		private UIHudArmsListView m_View;

		// Token: 0x04007A25 RID: 31269
		[Token(Token = "0x4007A25")]
		[FieldOffset(Offset = "0x60")]
		private uint m_DelayCall;

		// Token: 0x04007A26 RID: 31270
		[Token(Token = "0x4007A26")]
		[FieldOffset(Offset = "0x64")]
		private int m_DelayTime;

		// Token: 0x04007A27 RID: 31271
		[Token(Token = "0x4007A27")]
		[FieldOffset(Offset = "0x68")]
		private List<YmQ\u0082E\u007FN> m_ArmsInfoList;

		// Token: 0x04007A28 RID: 31272
		[Token(Token = "0x4007A28")]
		[FieldOffset(Offset = "0x70")]
		private List<UIHudArmsItemController> m_ArmsItemCtrl;
	}
}
