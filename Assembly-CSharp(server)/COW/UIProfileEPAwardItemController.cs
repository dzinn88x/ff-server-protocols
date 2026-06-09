using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001B24 RID: 6948
	[Token(Token = "0x2001B24")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F94E4", Offset = "0x10F94E4")]
	public class UIProfileEPAwardItemController : UIBaseController
	{
		// Token: 0x060094CD RID: 38093 RVA: 0x00027558 File Offset: 0x00025758
		[Token(Token = "0x60094CD")]
		[Address(RVA = "0x1B67B58", Offset = "0x1B67B58", VA = "0x7BBC367B58")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060094CE RID: 38094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094CE")]
		[Address(RVA = "0x1B67BA8", Offset = "0x1B67BA8", VA = "0x7BBC367BA8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060094CF RID: 38095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094CF")]
		[Address(RVA = "0x1B5631C", Offset = "0x1B5631C", VA = "0x7BBC35631C")]
		public void SetUIData(BasicEPInfo data)
		{
		}

		// Token: 0x060094D0 RID: 38096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094D0")]
		[Address(RVA = "0x1B67C0C", Offset = "0x1B67C0C", VA = "0x7BBC367C0C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060094D1 RID: 38097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094D1")]
		[Address(RVA = "0x1B67C14", Offset = "0x1B67C14", VA = "0x7BBC367C14", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x060094D2 RID: 38098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094D2")]
		[Address(RVA = "0x1B67C1C", Offset = "0x1B67C1C", VA = "0x7BBC367C1C")]
		public UIProfileEPAwardItemController()
		{
		}

		// Token: 0x04009E46 RID: 40518
		[Token(Token = "0x4009E46")]
		[FieldOffset(Offset = "0x58")]
		private UIProfileEpAwardItemView m_View;
	}
}
