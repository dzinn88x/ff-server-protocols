using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x020028C5 RID: 10437
	[Token(Token = "0x20028C5")]
	public class LevelTriggerHumanTire : MonoBehaviour
	{
		// Token: 0x17000F07 RID: 3847
		// (get) Token: 0x0600DD10 RID: 56592 RVA: 0x0003D2A8 File Offset: 0x0003B4A8
		// (set) Token: 0x0600DD11 RID: 56593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000F07")]
		public {QAb\u0082~u Cwnwze[
		{
			[Token(Token = "0x600DD10")]
			[Address(RVA = "0x1D46458", Offset = "0x1D46458", VA = "0x7BBC546458")]
			get
			{
				return default({QAb\u0082~u);
			}
			[Token(Token = "0x600DD11")]
			[Address(RVA = "0x1D4646C", Offset = "0x1D4646C", VA = "0x7BBC54646C")]
			set
			{
			}
		}

		// Token: 0x0600DD12 RID: 56594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD12")]
		[Address(RVA = "0x1D46480", Offset = "0x1D46480", VA = "0x7BBC546480")]
		public void PlayEffect()
		{
		}

		// Token: 0x0600DD13 RID: 56595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD13")]
		[Address(RVA = "0x1D46540", Offset = "0x1D46540", VA = "0x7BBC546540")]
		public void StopEffect()
		{
		}

		// Token: 0x0600DD14 RID: 56596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD14")]
		[Address(RVA = "0x1D465E0", Offset = "0x1D465E0", VA = "0x7BBC5465E0")]
		public void PlayOneShot()
		{
		}

		// Token: 0x0600DD15 RID: 56597 RVA: 0x0003D2C0 File Offset: 0x0003B4C0
		[Token(Token = "0x600DD15")]
		[Address(RVA = "0x1D4667C", Offset = "0x1D4667C", VA = "0x7BBC54667C")]
		public float GetColliderHeight()
		{
			return 0f;
		}

		// Token: 0x0600DD16 RID: 56598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD16")]
		[Address(RVA = "0x1D4671C", Offset = "0x1D4671C", VA = "0x7BBC54671C")]
		private void OnEnable()
		{
		}

		// Token: 0x0600DD17 RID: 56599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD17")]
		[Address(RVA = "0x1D46750", Offset = "0x1D46750", VA = "0x7BBC546750")]
		public LevelTriggerHumanTire()
		{
		}

		// Token: 0x04010D10 RID: 68880
		[Token(Token = "0x4010D10")]
		[FieldOffset(Offset = "0x18")]
		public GameObject effect;

		// Token: 0x04010D11 RID: 68881
		[Token(Token = "0x4010D11")]
		[FieldOffset(Offset = "0x20")]
		public float HSpeed;

		// Token: 0x04010D12 RID: 68882
		[Token(Token = "0x4010D12")]
		[FieldOffset(Offset = "0x24")]
		public float VSpeed;

		// Token: 0x04010D13 RID: 68883
		[Token(Token = "0x4010D13")]
		[FieldOffset(Offset = "0x28")]
		public CapsuleCollider collider;

		// Token: 0x04010D14 RID: 68884
		[Token(Token = "0x4010D14")]
		[FieldOffset(Offset = "0x30")]
		private {QAb\u0082~u cBMOX\u0080|;
	}
}
