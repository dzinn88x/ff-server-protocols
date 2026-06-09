using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x02002B55 RID: 11093
	[Token(Token = "0x2002B55")]
	internal class VehicleCollision : MonoBehaviour
	{
		// Token: 0x0600F4DD RID: 62685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F4DD")]
		[Address(RVA = "0x1DE4160", Offset = "0x1DE4160", VA = "0x7BBC5E4160")]
		private void Awake()
		{
		}

		// Token: 0x0600F4DE RID: 62686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F4DE")]
		[Address(RVA = "0x1DE4210", Offset = "0x1DE4210", VA = "0x7BBC5E4210")]
		public void OnTriggerEnter(Collider mvYAplG)
		{
		}

		// Token: 0x0600F4DF RID: 62687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F4DF")]
		[Address(RVA = "0x1DE4678", Offset = "0x1DE4678", VA = "0x7BBC5E4678")]
		public void OnTriggerExit(Collider mvYAplG)
		{
		}

		// Token: 0x0600F4E0 RID: 62688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F4E0")]
		[Address(RVA = "0x1DE4818", Offset = "0x1DE4818", VA = "0x7BBC5E4818")]
		public VehicleCollision()
		{
		}

		// Token: 0x040119B5 RID: 72117
		[Token(Token = "0x40119B5")]
		[FieldOffset(Offset = "0x18")]
		public Vehicle attachVehicle;

		// Token: 0x040119B6 RID: 72118
		[Token(Token = "0x40119B6")]
		[FieldOffset(Offset = "0x20")]
		public bool isKillCollision;

		// Token: 0x040119B7 RID: 72119
		[Token(Token = "0x40119B7")]
		[FieldOffset(Offset = "0x28")]
		private HashSet<Collider> \u0082}ZYQyS;

		// Token: 0x040119B8 RID: 72120
		[Token(Token = "0x40119B8")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 \u0081Lxov{S;
	}
}
