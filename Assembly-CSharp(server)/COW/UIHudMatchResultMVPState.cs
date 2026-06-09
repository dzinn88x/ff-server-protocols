using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020015D6 RID: 5590
	[Token(Token = "0x20015D6")]
	public class UIHudMatchResultMVPState : UIHudMatchResultStateBase
	{
		// Token: 0x0600630B RID: 25355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600630B")]
		[Address(RVA = "0x17AD388", Offset = "0x17AD388", VA = "0x7BBBFAD388")]
		public UIHudMatchResultMVPState(UIHudMatchResultStateMachine machine)
		{
		}

		// Token: 0x0600630C RID: 25356 RVA: 0x0001C8A8 File Offset: 0x0001AAA8
		[Token(Token = "0x600630C")]
		[Address(RVA = "0x17AD3C8", Offset = "0x17AD3C8", VA = "0x7BBBFAD3C8", Slot = "5")]
		protected override bool OnCheck()
		{
			return default(bool);
		}

		// Token: 0x0600630D RID: 25357 RVA: 0x0001C8C0 File Offset: 0x0001AAC0
		[Token(Token = "0x600630D")]
		[Address(RVA = "0x17AD4B8", Offset = "0x17AD4B8", VA = "0x7BBBFAD4B8", Slot = "6")]
		protected override bool OnEnter()
		{
			return default(bool);
		}

		// Token: 0x0600630E RID: 25358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600630E")]
		[Address(RVA = "0x17ADFE4", Offset = "0x17ADFE4", VA = "0x7BBBFADFE4", Slot = "7")]
		protected override void OnFinish()
		{
		}

		// Token: 0x0600630F RID: 25359 RVA: 0x0001C8D8 File Offset: 0x0001AAD8
		[Token(Token = "0x600630F")]
		[Address(RVA = "0x17AD66C", Offset = "0x17AD66C", VA = "0x7BBBFAD66C")]
		private bool CreateMVPRoom()
		{
			return default(bool);
		}

		// Token: 0x06006310 RID: 25360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006310")]
		[Address(RVA = "0x17AE150", Offset = "0x17AE150", VA = "0x7BBBFAE150")]
		private void SkipMVPAnim()
		{
		}

		// Token: 0x040081DC RID: 33244
		[Token(Token = "0x40081DC")]
		[FieldOffset(Offset = "0x20")]
		private Animation m_CameraAnimation;
	}
}
