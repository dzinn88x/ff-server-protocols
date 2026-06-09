using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x02002B3A RID: 11066
	[Token(Token = "0x2002B3A")]
	public class CameraTrackableEntityBase : MonoBehaviour, \u007F{KyDPR
	{
		// Token: 0x0600F316 RID: 62230 RVA: 0x000459D8 File Offset: 0x00043BD8
		[Token(Token = "0x600F316")]
		[Address(RVA = "0x17D045C", Offset = "0x17D045C", VA = "0x7BBBFD045C", Slot = "4")]
		public Vector3 GetCameraTrackableEntityPosition()
		{
			return default(Vector3);
		}

		// Token: 0x0600F317 RID: 62231 RVA: 0x000459F0 File Offset: 0x00043BF0
		[Token(Token = "0x600F317")]
		[Address(RVA = "0x17D0490", Offset = "0x17D0490", VA = "0x7BBBFD0490", Slot = "5")]
		public Vector3 GetCameraTrackableEntityTopPosition()
		{
			return default(Vector3);
		}

		// Token: 0x0600F318 RID: 62232 RVA: 0x00045A08 File Offset: 0x00043C08
		[Token(Token = "0x600F318")]
		[Address(RVA = "0x17D0560", Offset = "0x17D0560", VA = "0x7BBBFD0560", Slot = "6")]
		public Quaternion GetCameraTrackableEntityAimRotation()
		{
			return default(Quaternion);
		}

		// Token: 0x0600F319 RID: 62233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F319")]
		[Address(RVA = "0x17D05C0", Offset = "0x17D05C0", VA = "0x7BBBFD05C0", Slot = "7")]
		public Transform GetCameraTrackableEntityTransfrom()
		{
			return null;
		}

		// Token: 0x0600F31A RID: 62234 RVA: 0x00045A20 File Offset: 0x00043C20
		[Token(Token = "0x600F31A")]
		[Address(RVA = "0x17D05C8", Offset = "0x17D05C8", VA = "0x7BBBFD05C8", Slot = "8")]
		public bool IsCameraTrackableEntityAlive()
		{
			return default(bool);
		}

		// Token: 0x0600F31B RID: 62235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F31B")]
		[Address(RVA = "0x17D05D0", Offset = "0x17D05D0", VA = "0x7BBBFD05D0")]
		public CameraTrackableEntityBase()
		{
		}

		// Token: 0x04011899 RID: 71833
		[Token(Token = "0x4011899")]
		[FieldOffset(Offset = "0x18")]
		public float TopHeight;
	}
}
