using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001BD5 RID: 7125
	[Token(Token = "0x2001BD5")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FAF5C", Offset = "0x10FAF5C")]
	internal class UIWaitForCoolDownController : UIBaseController
	{
		// Token: 0x06009A19 RID: 39449 RVA: 0x00028920 File Offset: 0x00026B20
		[Token(Token = "0x6009A19")]
		[Address(RVA = "0x168520C", Offset = "0x168520C", VA = "0x7BBBE8520C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009A1A RID: 39450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A1A")]
		[Address(RVA = "0x168525C", Offset = "0x168525C", VA = "0x7BBBE8525C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009A1B RID: 39451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A1B")]
		[Address(RVA = "0x16852C0", Offset = "0x16852C0", VA = "0x7BBBE852C0")]
		private void Update()
		{
		}

		// Token: 0x06009A1C RID: 39452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A1C")]
		[Address(RVA = "0x1685444", Offset = "0x1685444", VA = "0x7BBBE85444")]
		public UIWaitForCoolDownController()
		{
		}

		// Token: 0x0400A114 RID: 41236
		[Token(Token = "0x400A114")]
		[FieldOffset(Offset = "0x58")]
		private UIWaitingCoolDownView m_View;

		// Token: 0x0400A115 RID: 41237
		[Token(Token = "0x400A115")]
		[FieldOffset(Offset = "0x60")]
		private int CoolDownSeconds;

		// Token: 0x0400A116 RID: 41238
		[Token(Token = "0x400A116")]
		[FieldOffset(Offset = "0x64")]
		private float m_Time;

		// Token: 0x0400A117 RID: 41239
		[Token(Token = "0x400A117")]
		[FieldOffset(Offset = "0x68")]
		private int m_SecondsLeft;
	}
}
