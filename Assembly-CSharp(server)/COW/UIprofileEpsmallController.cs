using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001B25 RID: 6949
	[Token(Token = "0x2001B25")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F951C", Offset = "0x10F951C")]
	public class UIprofileEpsmallController : UIBaseController
	{
		// Token: 0x060094D3 RID: 38099 RVA: 0x00027570 File Offset: 0x00025770
		[Token(Token = "0x60094D3")]
		[Address(RVA = "0x1793D7C", Offset = "0x1793D7C", VA = "0x7BBBF93D7C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060094D4 RID: 38100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094D4")]
		[Address(RVA = "0x1793DCC", Offset = "0x1793DCC", VA = "0x7BBBF93DCC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060094D5 RID: 38101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094D5")]
		[Address(RVA = "0x1793E30", Offset = "0x1793E30", VA = "0x7BBBF93E30")]
		public void RefreshData(BasicEPInfo info)
		{
		}

		// Token: 0x060094D6 RID: 38102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094D6")]
		[Address(RVA = "0x1794054", Offset = "0x1794054", VA = "0x7BBBF94054", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060094D7 RID: 38103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094D7")]
		[Address(RVA = "0x179405C", Offset = "0x179405C", VA = "0x7BBBF9405C", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x060094D8 RID: 38104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094D8")]
		[Address(RVA = "0x1794064", Offset = "0x1794064", VA = "0x7BBBF94064")]
		public UIprofileEpsmallController()
		{
		}

		// Token: 0x04009E47 RID: 40519
		[Token(Token = "0x4009E47")]
		[FieldOffset(Offset = "0x58")]
		private UIProfileEPSMallItemView m_View;
	}
}
