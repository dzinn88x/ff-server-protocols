using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001441 RID: 5185
	[Token(Token = "0x2001441")]
	public class LobbyAvatarLookAtComponent : MonoBehaviour
	{
		// Token: 0x0600561C RID: 22044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600561C")]
		[Address(RVA = "0x1407B40", Offset = "0x1407B40", VA = "0x7BBBC07B40")]
		private void Start()
		{
		}

		// Token: 0x0600561D RID: 22045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600561D")]
		[Address(RVA = "0x1407CE0", Offset = "0x1407CE0", VA = "0x7BBBC07CE0")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600561E RID: 22046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600561E")]
		[Address(RVA = "0x1408128", Offset = "0x1408128", VA = "0x7BBBC08128")]
		private void LerpToTarget(ref float cur, ref float tar, float step)
		{
		}

		// Token: 0x0600561F RID: 22047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600561F")]
		[Address(RVA = "0x1407B44", Offset = "0x1407B44", VA = "0x7BBBC07B44")]
		public void Init()
		{
		}

		// Token: 0x06005620 RID: 22048 RVA: 0x000199F8 File Offset: 0x00017BF8
		[Token(Token = "0x6005620")]
		[Address(RVA = "0x1408094", Offset = "0x1408094", VA = "0x7BBBC08094")]
		private bool CheckAnimState()
		{
			return default(bool);
		}

		// Token: 0x06005621 RID: 22049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005621")]
		[Address(RVA = "0x14081EC", Offset = "0x14081EC", VA = "0x7BBBC081EC")]
		public LobbyAvatarLookAtComponent()
		{
		}

		// Token: 0x06005622 RID: 22050 RVA: 0x00019A10 File Offset: 0x00017C10
		[Token(Token = "0x6005622")]
		[Address(RVA = "0x140832C", Offset = "0x140832C", VA = "0x7BBBC0832C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113EC84", Offset = "0x113EC84")]
		private bool <CheckAnimState>b__23_0(string state)
		{
			return default(bool);
		}

		// Token: 0x04007ADA RID: 31450
		[Token(Token = "0x4007ADA")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "RangeAttribute", RVA = "0x112F73C", Offset = "0x112F73C")]
		public float neckRatio;

		// Token: 0x04007ADB RID: 31451
		[Token(Token = "0x4007ADB")]
		[FieldOffset(Offset = "0x20")]
		public string[] animationState;

		// Token: 0x04007ADC RID: 31452
		[Token(Token = "0x4007ADC")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "RangeAttribute", RVA = "0x112F754", Offset = "0x112F754")]
		public float angleMin;

		// Token: 0x04007ADD RID: 31453
		[Token(Token = "0x4007ADD")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x112F770", Offset = "0x112F770")]
		public float angleMax;

		// Token: 0x04007ADE RID: 31454
		[Token(Token = "0x4007ADE")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "RangeAttribute", RVA = "0x112F78C", Offset = "0x112F78C")]
		public float angleInMin;

		// Token: 0x04007ADF RID: 31455
		[Token(Token = "0x4007ADF")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "RangeAttribute", RVA = "0x112F7AC", Offset = "0x112F7AC")]
		public float angleInMax;

		// Token: 0x04007AE0 RID: 31456
		[Token(Token = "0x4007AE0")]
		[FieldOffset(Offset = "0x38")]
		public float turnSpeed;

		// Token: 0x04007AE1 RID: 31457
		[Token(Token = "0x4007AE1")]
		[FieldOffset(Offset = "0x3C")]
		public float inLerpSpeed;

		// Token: 0x04007AE2 RID: 31458
		[Token(Token = "0x4007AE2")]
		[FieldOffset(Offset = "0x40")]
		private Animator m_Animator;

		// Token: 0x04007AE3 RID: 31459
		[Token(Token = "0x4007AE3")]
		[FieldOffset(Offset = "0x48")]
		private Transform m_boneNeck;

		// Token: 0x04007AE4 RID: 31460
		[Token(Token = "0x4007AE4")]
		[FieldOffset(Offset = "0x50")]
		private Transform m_boneSpine1;

		// Token: 0x04007AE5 RID: 31461
		[Token(Token = "0x4007AE5")]
		[FieldOffset(Offset = "0x58")]
		private Transform m_character;

		// Token: 0x04007AE6 RID: 31462
		[Token(Token = "0x4007AE6")]
		[FieldOffset(Offset = "0x60")]
		private float m_curNeck;

		// Token: 0x04007AE7 RID: 31463
		[Token(Token = "0x4007AE7")]
		[FieldOffset(Offset = "0x64")]
		private float m_curSpine1;

		// Token: 0x04007AE8 RID: 31464
		[Token(Token = "0x4007AE8")]
		[FieldOffset(Offset = "0x68")]
		private float m_tarNeck;

		// Token: 0x04007AE9 RID: 31465
		[Token(Token = "0x4007AE9")]
		[FieldOffset(Offset = "0x6C")]
		private float m_tarSpine1;

		// Token: 0x04007AEA RID: 31466
		[Token(Token = "0x4007AEA")]
		[FieldOffset(Offset = "0x70")]
		private float m_rotateSpeed;

		// Token: 0x04007AEB RID: 31467
		[Token(Token = "0x4007AEB")]
		[FieldOffset(Offset = "0x74")]
		private float m_lastAngle;

		// Token: 0x04007AEC RID: 31468
		[Token(Token = "0x4007AEC")]
		[FieldOffset(Offset = "0x78")]
		private float m_curAngle;
	}
}
