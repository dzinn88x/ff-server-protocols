using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x0200291E RID: 10526
	[Token(Token = "0x200291E")]
	internal class AirTransporter : Entity, \u007F{KyDPR
	{
		// Token: 0x0600DFFA RID: 57338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFFA")]
		[Address(RVA = "0x18BFF74", Offset = "0x18BFF74", VA = "0x7BBC0BFF74", Slot = "11")]
		protected override void OnAwake()
		{
		}

		// Token: 0x0600DFFB RID: 57339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFFB")]
		[Address(RVA = "0x18C0034", Offset = "0x18C0034", VA = "0x7BBC0C0034", Slot = "13")]
		protected override void OnOnDestroy()
		{
		}

		// Token: 0x0600DFFC RID: 57340 RVA: 0x0003E160 File Offset: 0x0003C360
		[Token(Token = "0x600DFFC")]
		[Address(RVA = "0x18C00F4", Offset = "0x18C00F4", VA = "0x7BBC0C00F4", Slot = "20")]
		public Vector3 GetCameraTrackableEntityPosition()
		{
			return default(Vector3);
		}

		// Token: 0x0600DFFD RID: 57341 RVA: 0x0003E178 File Offset: 0x0003C378
		[Token(Token = "0x600DFFD")]
		[Address(RVA = "0x18C0128", Offset = "0x18C0128", VA = "0x7BBC0C0128", Slot = "21")]
		public Vector3 GetCameraTrackableEntityTopPosition()
		{
			return default(Vector3);
		}

		// Token: 0x0600DFFE RID: 57342 RVA: 0x0003E190 File Offset: 0x0003C390
		[Token(Token = "0x600DFFE")]
		[Address(RVA = "0x18C015C", Offset = "0x18C015C", VA = "0x7BBC0C015C", Slot = "22")]
		public Quaternion GetCameraTrackableEntityAimRotation()
		{
			return default(Quaternion);
		}

		// Token: 0x0600DFFF RID: 57343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DFFF")]
		[Address(RVA = "0x18C0190", Offset = "0x18C0190", VA = "0x7BBC0C0190", Slot = "23")]
		public Transform GetCameraTrackableEntityTransfrom()
		{
			return null;
		}

		// Token: 0x0600E000 RID: 57344 RVA: 0x0003E1A8 File Offset: 0x0003C3A8
		[Token(Token = "0x600E000")]
		[Address(RVA = "0x18C0198", Offset = "0x18C0198", VA = "0x7BBC0C0198", Slot = "24")]
		public bool IsCameraTrackableEntityAlive()
		{
			return default(bool);
		}

		// Token: 0x0600E001 RID: 57345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E001")]
		[Address(RVA = "0x18C01A0", Offset = "0x18C01A0", VA = "0x7BBC0C01A0")]
		public void SelectAirline(AirtransportParams A[}skZE)
		{
		}

		// Token: 0x0600E002 RID: 57346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E002")]
		[Address(RVA = "0x18C036C", Offset = "0x18C036C", VA = "0x7BBC0C036C")]
		public void SetOnBoard(Transform bqdVnD\u007F)
		{
		}

		// Token: 0x0600E003 RID: 57347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E003")]
		[Address(RVA = "0x18C049C", Offset = "0x18C049C", VA = "0x7BBC0C049C")]
		public void SetOffBoard(Transform bqdVnD\u007F)
		{
		}

		// Token: 0x0600E004 RID: 57348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E004")]
		[Address(RVA = "0x18C04F4", Offset = "0x18C04F4", VA = "0x7BBC0C04F4")]
		public void TryGetOffBoard(Transform bqdVnD\u007F)
		{
		}

		// Token: 0x0600E005 RID: 57349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E005")]
		[Address(RVA = "0x18C05B0", Offset = "0x18C05B0", VA = "0x7BBC0C05B0", Slot = "14")]
		public override void OnFixedUpdate(float \u0081}x[tOF, float OsUltaA)
		{
		}

		// Token: 0x0600E006 RID: 57350 RVA: 0x0003E1C0 File Offset: 0x0003C3C0
		[Token(Token = "0x600E006")]
		[Address(RVA = "0x18C0894", Offset = "0x18C0894", VA = "0x7BBC0C0894")]
		public Vector3 GetMovingVector()
		{
			return default(Vector3);
		}

		// Token: 0x0600E007 RID: 57351 RVA: 0x0003E1D8 File Offset: 0x0003C3D8
		[Token(Token = "0x600E007")]
		[Address(RVA = "0x18C08A0", Offset = "0x18C08A0", VA = "0x7BBC0C08A0")]
		public bool IsForceToJump({QAb\u0082~u BSUcaaw)
		{
			return default(bool);
		}

		// Token: 0x0600E008 RID: 57352 RVA: 0x0003E1F0 File Offset: 0x0003C3F0
		[Token(Token = "0x600E008")]
		[Address(RVA = "0x18C0B60", Offset = "0x18C0B60", VA = "0x7BBC0C0B60")]
		public bool CanJump()
		{
			return default(bool);
		}

		// Token: 0x0600E009 RID: 57353 RVA: 0x0003E208 File Offset: 0x0003C408
		[Token(Token = "0x600E009")]
		[Address(RVA = "0x18C0C08", Offset = "0x18C0C08", VA = "0x7BBC0C0C08")]
		public bool CanJump(float nXxSfxX)
		{
			return default(bool);
		}

		// Token: 0x0600E00A RID: 57354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E00A")]
		[Address(RVA = "0x18C0C18", Offset = "0x18C0C18", VA = "0x7BBC0C0C18")]
		public AirtransportParams GetParam()
		{
			return null;
		}

		// Token: 0x0600E00B RID: 57355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E00B")]
		[Address(RVA = "0x18C0C20", Offset = "0x18C0C20", VA = "0x7BBC0C0C20")]
		public void OnOpeningStart()
		{
		}

		// Token: 0x0600E00C RID: 57356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E00C")]
		[Address(RVA = "0x18C109C", Offset = "0x18C109C", VA = "0x7BBC0C109C")]
		public void OnOpeningEnd(object[] QmG~NaB)
		{
		}

		// Token: 0x0600E00D RID: 57357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E00D")]
		[Address(RVA = "0x18C0F38", Offset = "0x18C0F38", VA = "0x7BBC0C0F38")]
		private void jHC[[|k(bool oDf^\u0081Hp)
		{
		}

		// Token: 0x0600E00E RID: 57358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E00E")]
		[Address(RVA = "0x18C12DC", Offset = "0x18C12DC", VA = "0x7BBC0C12DC")]
		public AirTransporter()
		{
		}

		// Token: 0x04010F0F RID: 69391
		[Token(Token = "0x4010F0F")]
		[FieldOffset(Offset = "0x30")]
		public Transform m_PassengerContainer;

		// Token: 0x04010F10 RID: 69392
		[Token(Token = "0x4010F10")]
		[FieldOffset(Offset = "0x38")]
		public Transform m_Model;

		// Token: 0x04010F11 RID: 69393
		[Token(Token = "0x4010F11")]
		[FieldOffset(Offset = "0x40")]
		public bool UseAnimationA;

		// Token: 0x04010F12 RID: 69394
		[Token(Token = "0x4010F12")]
		[FieldOffset(Offset = "0x48")]
		private AirtransportParams k\u007FRw\u007FSe;

		// Token: 0x04010F13 RID: 69395
		[Token(Token = "0x4010F13")]
		[FieldOffset(Offset = "0x50")]
		private float PqagWjX;

		// Token: 0x04010F14 RID: 69396
		[Token(Token = "0x4010F14")]
		[FieldOffset(Offset = "0x54")]
		private Vector3 zhfqTTz;

		// Token: 0x04010F15 RID: 69397
		[Token(Token = "0x4010F15")]
		[FieldOffset(Offset = "0x60")]
		private GameObject <<EMPTY_NAME>>;

		// Token: 0x04010F16 RID: 69398
		[Token(Token = "0x4010F16")]
		[FieldOffset(Offset = "0x68")]
		private uint \u0082mt}i|k;

		// Token: 0x04010F17 RID: 69399
		[Token(Token = "0x4010F17")]
		[FieldOffset(Offset = "0x70")]
		private Transform KtKjUOs;

		// Token: 0x04010F18 RID: 69400
		[Token(Token = "0x4010F18")]
		[FieldOffset(Offset = "0x78")]
		private PostEffectManager NMbXdxP;

		// Token: 0x0200291F RID: 10527
		[Token(Token = "0x200291F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FEE70", Offset = "0x10FEE70")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600E010 RID: 57360 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E010")]
			[Address(RVA = "0x18C13A8", Offset = "0x18C13A8", VA = "0x7BBC0C13A8")]
			public <>c()
			{
			}

			// Token: 0x0600E011 RID: 57361 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E011")]
			[Address(RVA = "0x18C13B0", Offset = "0x18C13B0", VA = "0x7BBC0C13B0")]
			internal void T{OyDDs()
			{
			}

			// Token: 0x04010F19 RID: 69401
			[Token(Token = "0x4010F19")]
			[FieldOffset(Offset = "0x0")]
			public static readonly AirTransporter.<>c <>9;

			// Token: 0x04010F1A RID: 69402
			[Token(Token = "0x4010F1A")]
			[FieldOffset(Offset = "0x8")]
			public static Action <>9__21_0;
		}
	}
}
