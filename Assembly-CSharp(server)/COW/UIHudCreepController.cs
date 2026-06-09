using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001899 RID: 6297
	[Token(Token = "0x2001899")]
	internal class UIHudCreepController : UIHudButtonBaseController
	{
		// Token: 0x06007CD5 RID: 31957 RVA: 0x000224A0 File Offset: 0x000206A0
		[Token(Token = "0x6007CD5")]
		[Address(RVA = "0x1A96AB0", Offset = "0x1A96AB0", VA = "0x7BBC296AB0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007CD6 RID: 31958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CD6")]
		[Address(RVA = "0x1A96B00", Offset = "0x1A96B00", VA = "0x7BBC296B00", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007CD7 RID: 31959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007CD7")]
		[Address(RVA = "0x1A96B7C", Offset = "0x1A96B7C", VA = "0x7BBC296B7C", Slot = "33")]
		protected override string GetMappingName()
		{
			return null;
		}

		// Token: 0x06007CD8 RID: 31960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CD8")]
		[Address(RVA = "0x1A96BC4", Offset = "0x1A96BC4", VA = "0x7BBC296BC4")]
		private void Update()
		{
		}

		// Token: 0x06007CD9 RID: 31961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CD9")]
		[Address(RVA = "0x1A96CA4", Offset = "0x1A96CA4", VA = "0x7BBC296CA4")]
		private void SetHightlight(bool highlight)
		{
		}

		// Token: 0x06007CDA RID: 31962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CDA")]
		[Address(RVA = "0x1A96DE0", Offset = "0x1A96DE0", VA = "0x7BBC296DE0")]
		public UIHudCreepController()
		{
		}

		// Token: 0x0400908A RID: 37002
		[Token(Token = "0x400908A")]
		[FieldOffset(Offset = "0x60")]
		private UIHudCreepView m_View;

		// Token: 0x0400908B RID: 37003
		[Token(Token = "0x400908B")]
		[FieldOffset(Offset = "0x68")]
		private bool m_IsHighlight;
	}
}
