using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200143D RID: 5181
	[Token(Token = "0x200143D")]
	public class AvatarCameraMoveComp : MonoBehaviour
	{
		// Token: 0x0600560D RID: 22029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600560D")]
		[Address(RVA = "0x155CAD8", Offset = "0x155CAD8", VA = "0x7BBBD5CAD8")]
		public void SetOriginInfo(Vector3 prePos, float preBgSize, GameObject bgObj, GameObject camObj, float moveDuration = 1f)
		{
		}

		// Token: 0x0600560E RID: 22030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600560E")]
		[Address(RVA = "0x155CAEC", Offset = "0x155CAEC", VA = "0x7BBBD5CAEC")]
		public void SetLerpInfo(GameObject obj, GameObject camera, Vector3 start, Vector3 end, float bgstart, float bgend)
		{
		}

		// Token: 0x0600560F RID: 22031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600560F")]
		[Address(RVA = "0x155CB10", Offset = "0x155CB10", VA = "0x7BBBD5CB10")]
		public void SetSimpleLerpInfo(Vector3 start, Vector3 end, float bgstart, float bgend)
		{
		}

		// Token: 0x06005610 RID: 22032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005610")]
		[Address(RVA = "0x155CB30", Offset = "0x155CB30", VA = "0x7BBBD5CB30")]
		public void SetMoveing()
		{
		}

		// Token: 0x06005611 RID: 22033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005611")]
		[Address(RVA = "0x155CB4C", Offset = "0x155CB4C", VA = "0x7BBBD5CB4C")]
		private void OnEnable()
		{
		}

		// Token: 0x06005612 RID: 22034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005612")]
		[Address(RVA = "0x155CB50", Offset = "0x155CB50", VA = "0x7BBBD5CB50")]
		private void OnDisable()
		{
		}

		// Token: 0x06005613 RID: 22035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005613")]
		[Address(RVA = "0x155CCFC", Offset = "0x155CCFC", VA = "0x7BBBD5CCFC")]
		private void Update()
		{
		}

		// Token: 0x06005614 RID: 22036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005614")]
		[Address(RVA = "0x155D0F4", Offset = "0x155D0F4", VA = "0x7BBBD5D0F4")]
		public AvatarCameraMoveComp()
		{
		}

		// Token: 0x04007AC3 RID: 31427
		[Token(Token = "0x4007AC3")]
		[FieldOffset(Offset = "0x18")]
		private Vector3 lerpstart;

		// Token: 0x04007AC4 RID: 31428
		[Token(Token = "0x4007AC4")]
		[FieldOffset(Offset = "0x24")]
		private Vector3 lerpend;

		// Token: 0x04007AC5 RID: 31429
		[Token(Token = "0x4007AC5")]
		[FieldOffset(Offset = "0x30")]
		private float lerpbgstart;

		// Token: 0x04007AC6 RID: 31430
		[Token(Token = "0x4007AC6")]
		[FieldOffset(Offset = "0x34")]
		private float lerpbgend;

		// Token: 0x04007AC7 RID: 31431
		[Token(Token = "0x4007AC7")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 currentPos;

		// Token: 0x04007AC8 RID: 31432
		[Token(Token = "0x4007AC8")]
		[FieldOffset(Offset = "0x44")]
		private float currentBgPos;

		// Token: 0x04007AC9 RID: 31433
		[Token(Token = "0x4007AC9")]
		[FieldOffset(Offset = "0x48")]
		private GameObject BgObj;

		// Token: 0x04007ACA RID: 31434
		[Token(Token = "0x4007ACA")]
		[FieldOffset(Offset = "0x50")]
		private GameObject CameraObj;

		// Token: 0x04007ACB RID: 31435
		[Token(Token = "0x4007ACB")]
		[FieldOffset(Offset = "0x58")]
		public float currentmovetime;

		// Token: 0x04007ACC RID: 31436
		[Token(Token = "0x4007ACC")]
		[FieldOffset(Offset = "0x5C")]
		private bool IsMoving;

		// Token: 0x04007ACD RID: 31437
		[Token(Token = "0x4007ACD")]
		[FieldOffset(Offset = "0x60")]
		private float m_Movetime;

		// Token: 0x04007ACE RID: 31438
		[Token(Token = "0x4007ACE")]
		[FieldOffset(Offset = "0x64")]
		private float m_orignbg;

		// Token: 0x04007ACF RID: 31439
		[Token(Token = "0x4007ACF")]
		[FieldOffset(Offset = "0x68")]
		private Vector3 m_orignpos;
	}
}
