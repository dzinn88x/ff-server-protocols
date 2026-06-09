using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200162B RID: 5675
	[Token(Token = "0x200162B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EFCD4", Offset = "0x10EFCD4")]
	internal class UIHUDPVEMissionItemController : UIBaseController
	{
		// Token: 0x06006613 RID: 26131 RVA: 0x0001D250 File Offset: 0x0001B450
		[Token(Token = "0x6006613")]
		[Address(RVA = "0x16BBE70", Offset = "0x16BBE70", VA = "0x7BBBEBBE70")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006614 RID: 26132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006614")]
		[Address(RVA = "0x16BBEC0", Offset = "0x16BBEC0", VA = "0x7BBBEBBEC0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006615 RID: 26133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006615")]
		[Address(RVA = "0x16BBF24", Offset = "0x16BBF24", VA = "0x7BBBEBBF24")]
		public void OnDataCome(string content)
		{
		}

		// Token: 0x06006616 RID: 26134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006616")]
		[Address(RVA = "0x16BBF6C", Offset = "0x16BBF6C", VA = "0x7BBBEBBF6C")]
		public UIHUDPVEMissionItemController()
		{
		}

		// Token: 0x04008405 RID: 33797
		[Token(Token = "0x4008405")]
		[FieldOffset(Offset = "0x58")]
		public HUDPVEMissionItemView m_View;
	}
}
