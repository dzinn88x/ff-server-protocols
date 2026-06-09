using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001895 RID: 6293
	[Token(Token = "0x2001895")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F4684", Offset = "0x10F4684")]
	internal class UIHudControlIntroInfoController : UIBaseController
	{
		// Token: 0x06007CB0 RID: 31920 RVA: 0x000223E0 File Offset: 0x000205E0
		[Token(Token = "0x6007CB0")]
		[Address(RVA = "0x1A91C88", Offset = "0x1A91C88", VA = "0x7BBC291C88")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007CB1 RID: 31921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CB1")]
		[Address(RVA = "0x1A91CD8", Offset = "0x1A91CD8", VA = "0x7BBC291CD8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007CB2 RID: 31922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CB2")]
		[Address(RVA = "0x1A91DB8", Offset = "0x1A91DB8", VA = "0x7BBC291DB8", Slot = "20")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06007CB3 RID: 31923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CB3")]
		[Address(RVA = "0x1A91EDC", Offset = "0x1A91EDC", VA = "0x7BBC291EDC")]
		private void OnControlPhaseChange(params object[] data)
		{
		}

		// Token: 0x06007CB4 RID: 31924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CB4")]
		[Address(RVA = "0x1A92024", Offset = "0x1A92024", VA = "0x7BBC292024")]
		public UIHudControlIntroInfoController()
		{
		}

		// Token: 0x06007CB5 RID: 31925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CB5")]
		[Address(RVA = "0x1A9202C", Offset = "0x1A9202C", VA = "0x7BBC29202C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114297C", Offset = "0x114297C")]
		private void <OnControlPhaseChange>b__4_0()
		{
		}

		// Token: 0x0400907C RID: 36988
		[Token(Token = "0x400907C")]
		[FieldOffset(Offset = "0x58")]
		private uint m_DelayCallId;
	}
}
