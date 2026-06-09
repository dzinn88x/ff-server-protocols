using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001726 RID: 5926
	[Token(Token = "0x2001726")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F1914", Offset = "0x10F1914")]
	public class UIClanDetailController : UIPopupWindowController
	{
		// Token: 0x06006EC0 RID: 28352 RVA: 0x0001F260 File Offset: 0x0001D460
		[Token(Token = "0x6006EC0")]
		[Address(RVA = "0x1CFA8FC", Offset = "0x1CFA8FC", VA = "0x7BBC4FA8FC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006EC1 RID: 28353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EC1")]
		[Address(RVA = "0x1CFA94C", Offset = "0x1CFA94C", VA = "0x7BBC4FA94C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006EC2 RID: 28354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EC2")]
		[Address(RVA = "0x1CFAA24", Offset = "0x1CFAA24", VA = "0x7BBC4FAA24")]
		public void SetUIdata(ClanInfoBasic claninfo, AccountInfoBasic clancaptaininfo)
		{
		}

		// Token: 0x06006EC3 RID: 28355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EC3")]
		[Address(RVA = "0x1CFAF80", Offset = "0x1CFAF80", VA = "0x7BBC4FAF80")]
		public UIClanDetailController()
		{
		}

		// Token: 0x04008930 RID: 35120
		[Token(Token = "0x4008930")]
		[FieldOffset(Offset = "0x98")]
		private UIClanDetailsView m_View;

		// Token: 0x04008931 RID: 35121
		[Token(Token = "0x4008931")]
		[FieldOffset(Offset = "0xA0")]
		private UIBaseProfileInfoController m_BaseProfile;
	}
}
