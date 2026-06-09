using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001879 RID: 6265
	[Token(Token = "0x2001879")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F42D4", Offset = "0x10F42D4")]
	public class UIHudBattleFlagController : UIBaseController
	{
		// Token: 0x06007BD4 RID: 31700 RVA: 0x00022080 File Offset: 0x00020280
		[Token(Token = "0x6007BD4")]
		[Address(RVA = "0x1893418", Offset = "0x1893418", VA = "0x7BBC093418")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007BD5 RID: 31701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BD5")]
		[Address(RVA = "0x1893468", Offset = "0x1893468", VA = "0x7BBC093468", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007BD6 RID: 31702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BD6")]
		[Address(RVA = "0x18936B4", Offset = "0x18936B4", VA = "0x7BBC0936B4")]
		private void OnShowChanged(params object[] data)
		{
		}

		// Token: 0x06007BD7 RID: 31703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BD7")]
		[Address(RVA = "0x1893784", Offset = "0x1893784", VA = "0x7BBC093784")]
		private void OnUseBattleFlag()
		{
		}

		// Token: 0x06007BD8 RID: 31704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BD8")]
		[Address(RVA = "0x189386C", Offset = "0x189386C", VA = "0x7BBC09386C")]
		public UIHudBattleFlagController()
		{
		}

		// Token: 0x04009023 RID: 36899
		[Token(Token = "0x4009023")]
		[FieldOffset(Offset = "0x58")]
		private UIHudBattleFlagView m_View;
	}
}
