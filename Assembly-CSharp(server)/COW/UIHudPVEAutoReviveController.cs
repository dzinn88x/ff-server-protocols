using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200161F RID: 5663
	[Token(Token = "0x200161F")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EFB54", Offset = "0x10EFB54")]
	public class UIHudPVEAutoReviveController : UIBaseController
	{
		// Token: 0x060065C5 RID: 26053 RVA: 0x0001D130 File Offset: 0x0001B330
		[Token(Token = "0x60065C5")]
		[Address(RVA = "0x17BF4A0", Offset = "0x17BF4A0", VA = "0x7BBBFBF4A0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060065C6 RID: 26054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065C6")]
		[Address(RVA = "0x17BF4F0", Offset = "0x17BF4F0", VA = "0x7BBBFBF4F0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060065C7 RID: 26055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065C7")]
		[Address(RVA = "0x17BF5AC", Offset = "0x17BF5AC", VA = "0x7BBBFBF5AC")]
		public void SetUIData(bool isTeamKill, int leftTime)
		{
		}

		// Token: 0x060065C8 RID: 26056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065C8")]
		[Address(RVA = "0x17BF644", Offset = "0x17BF644", VA = "0x7BBBFBF644")]
		private void Update()
		{
		}

		// Token: 0x060065C9 RID: 26057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065C9")]
		[Address(RVA = "0x17BF804", Offset = "0x17BF804", VA = "0x7BBBFBF804")]
		public UIHudPVEAutoReviveController()
		{
		}

		// Token: 0x040083DF RID: 33759
		[Token(Token = "0x40083DF")]
		[FieldOffset(Offset = "0x58")]
		private UIHUDPVEAutoReviveInfoView m_view;

		// Token: 0x040083E0 RID: 33760
		[Token(Token = "0x40083E0")]
		[FieldOffset(Offset = "0x60")]
		private float m_LeftTime;
	}
}
