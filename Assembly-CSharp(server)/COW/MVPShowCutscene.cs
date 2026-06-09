using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200160A RID: 5642
	[Token(Token = "0x200160A")]
	public class MVPShowCutscene : MonoBehaviour
	{
		// Token: 0x06006525 RID: 25893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006525")]
		[Address(RVA = "0x1A558FC", Offset = "0x1A558FC", VA = "0x7BBC2558FC")]
		public Transform[] GetAvatarTrans()
		{
			return null;
		}

		// Token: 0x06006526 RID: 25894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006526")]
		[Address(RVA = "0x1A55A9C", Offset = "0x1A55A9C", VA = "0x7BBC255A9C")]
		public MVPShowCutscene()
		{
		}

		// Token: 0x04008369 RID: 33641
		[Token(Token = "0x4008369")]
		[FieldOffset(Offset = "0x18")]
		public GameObject Scene;

		// Token: 0x0400836A RID: 33642
		[Token(Token = "0x400836A")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Cam;

		// Token: 0x0400836B RID: 33643
		[Token(Token = "0x400836B")]
		[FieldOffset(Offset = "0x28")]
		public Animator CamAnim;

		// Token: 0x0400836C RID: 33644
		[Token(Token = "0x400836C")]
		[FieldOffset(Offset = "0x30")]
		public GameObject MVPFemaleEffect;

		// Token: 0x0400836D RID: 33645
		[Token(Token = "0x400836D")]
		[FieldOffset(Offset = "0x38")]
		public GameObject MVPMaleEffect;

		// Token: 0x0400836E RID: 33646
		[Token(Token = "0x400836E")]
		[FieldOffset(Offset = "0x40")]
		public Transform MVPAvatar;

		// Token: 0x0400836F RID: 33647
		[Token(Token = "0x400836F")]
		[FieldOffset(Offset = "0x48")]
		public Transform Teammate1Avatar;

		// Token: 0x04008370 RID: 33648
		[Token(Token = "0x4008370")]
		[FieldOffset(Offset = "0x50")]
		public Transform Teammate2Avatar;

		// Token: 0x04008371 RID: 33649
		[Token(Token = "0x4008371")]
		[FieldOffset(Offset = "0x58")]
		public Transform Teammate3Avatar;
	}
}
