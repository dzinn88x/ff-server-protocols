using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020018C8 RID: 6344
	[Token(Token = "0x20018C8")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F4D34", Offset = "0x10F4D34")]
	internal class UIHudGamePhaseCountdownTimeController : UIBaseController
	{
		// Token: 0x06007E5A RID: 32346 RVA: 0x000228D8 File Offset: 0x00020AD8
		[Token(Token = "0x6007E5A")]
		[Address(RVA = "0x1C135D0", Offset = "0x1C135D0", VA = "0x7BBC4135D0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007E5B RID: 32347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E5B")]
		[Address(RVA = "0x1C13620", Offset = "0x1C13620", VA = "0x7BBC413620", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007E5C RID: 32348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E5C")]
		[Address(RVA = "0x1C1375C", Offset = "0x1C1375C", VA = "0x7BBC41375C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007E5D RID: 32349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E5D")]
		[Address(RVA = "0x1C13828", Offset = "0x1C13828", VA = "0x7BBC413828")]
		private void OnPhaseChange(params object[] data)
		{
		}

		// Token: 0x06007E5E RID: 32350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E5E")]
		[Address(RVA = "0x1C13BA8", Offset = "0x1C13BA8", VA = "0x7BBC413BA8")]
		private void Update()
		{
		}

		// Token: 0x06007E5F RID: 32351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E5F")]
		[Address(RVA = "0x1C13C1C", Offset = "0x1C13C1C", VA = "0x7BBC413C1C")]
		public UIHudGamePhaseCountdownTimeController()
		{
		}

		// Token: 0x040091B7 RID: 37303
		[Token(Token = "0x40091B7")]
		[FieldOffset(Offset = "0x58")]
		private UIHudGamePhaseCountdownHintView m_View;

		// Token: 0x040091B8 RID: 37304
		[Token(Token = "0x40091B8")]
		[FieldOffset(Offset = "0x60")]
		private string m_ExtraString;

		// Token: 0x040091B9 RID: 37305
		[Token(Token = "0x40091B9")]
		[FieldOffset(Offset = "0x68")]
		private UITimeLabelHelper m_TimeHelper;
	}
}
