using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C09 RID: 7177
	[Token(Token = "0x2001C09")]
	internal class UIHUDWolfKillActionController : UIBaseController
	{
		// Token: 0x06009C2D RID: 39981 RVA: 0x00028FC8 File Offset: 0x000271C8
		[Token(Token = "0x6009C2D")]
		[Address(RVA = "0x1D5AF94", Offset = "0x1D5AF94", VA = "0x7BBC55AF94")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009C2E RID: 39982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C2E")]
		[Address(RVA = "0x1D5AFE4", Offset = "0x1D5AFE4", VA = "0x7BBC55AFE4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009C2F RID: 39983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C2F")]
		[Address(RVA = "0x1D5B1A4", Offset = "0x1D5B1A4", VA = "0x7BBC55B1A4", Slot = "20")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06009C30 RID: 39984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C30")]
		[Address(RVA = "0x1D5B270", Offset = "0x1D5B270", VA = "0x7BBC55B270")]
		private void Update()
		{
		}

		// Token: 0x06009C31 RID: 39985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C31")]
		[Address(RVA = "0x1D5B3A0", Offset = "0x1D5B3A0", VA = "0x7BBC55B3A0")]
		private void UpdateValid()
		{
		}

		// Token: 0x06009C32 RID: 39986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C32")]
		[Address(RVA = "0x1D5B78C", Offset = "0x1D5B78C", VA = "0x7BBC55B78C")]
		private void ChooseNewTarget()
		{
		}

		// Token: 0x06009C33 RID: 39987 RVA: 0x00028FE0 File Offset: 0x000271E0
		[Token(Token = "0x6009C33")]
		[Address(RVA = "0x1D5B690", Offset = "0x1D5B690", VA = "0x7BBC55B690")]
		private bool IsPlayerValidTarget(Player player)
		{
			return default(bool);
		}

		// Token: 0x06009C34 RID: 39988 RVA: 0x00028FF8 File Offset: 0x000271F8
		[Token(Token = "0x6009C34")]
		[Address(RVA = "0x1D5BA94", Offset = "0x1D5BA94", VA = "0x7BBC55BA94")]
		private bool CheckInKillRange(Vector3 targetPos)
		{
			return default(bool);
		}

		// Token: 0x06009C35 RID: 39989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C35")]
		[Address(RVA = "0x1D5B294", Offset = "0x1D5B294", VA = "0x7BBC55B294")]
		private void UpdateCD()
		{
		}

		// Token: 0x06009C36 RID: 39990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C36")]
		[Address(RVA = "0x1D5BBF4", Offset = "0x1D5BBF4", VA = "0x7BBC55BBF4")]
		private void StopCD()
		{
		}

		// Token: 0x06009C37 RID: 39991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C37")]
		[Address(RVA = "0x1D5B644", Offset = "0x1D5B644", VA = "0x7BBC55B644")]
		private void OnActionEnable(bool isEnable)
		{
		}

		// Token: 0x06009C38 RID: 39992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C38")]
		[Address(RVA = "0x1D5BC50", Offset = "0x1D5BC50", VA = "0x7BBC55BC50")]
		private void Kill()
		{
		}

		// Token: 0x06009C39 RID: 39993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C39")]
		[Address(RVA = "0x1D5BFEC", Offset = "0x1D5BFEC", VA = "0x7BBC55BFEC")]
		private void PlayKillEffect(Vector3 beginPos, Vector3 targetPos)
		{
		}

		// Token: 0x06009C3A RID: 39994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C3A")]
		[Address(RVA = "0x1D5C2D0", Offset = "0x1D5C2D0", VA = "0x7BBC55C2D0")]
		private void OnKillCd(params object[] data)
		{
		}

		// Token: 0x06009C3B RID: 39995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009C3B")]
		[Address(RVA = "0x1D5C3B8", Offset = "0x1D5C3B8", VA = "0x7BBC55C3B8")]
		public Transform GetShowRoot()
		{
			return null;
		}

		// Token: 0x06009C3C RID: 39996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C3C")]
		[Address(RVA = "0x1D5C3D0", Offset = "0x1D5C3D0", VA = "0x7BBC55C3D0")]
		public UIHUDWolfKillActionController()
		{
		}

		// Token: 0x0400A220 RID: 41504
		[Token(Token = "0x400A220")]
		[FieldOffset(Offset = "0x58")]
		private UIHUDWolfKillActionView m_View;

		// Token: 0x0400A221 RID: 41505
		[Token(Token = "0x400A221")]
		[FieldOffset(Offset = "0x60")]
		private {QAb\u0082~u m_TargetID;

		// Token: 0x0400A222 RID: 41506
		[Token(Token = "0x400A222")]
		[FieldOffset(Offset = "0x78")]
		private bool m_IsInCD;

		// Token: 0x0400A223 RID: 41507
		[Token(Token = "0x400A223")]
		[FieldOffset(Offset = "0x7C")]
		private float m_CDEndTime;

		// Token: 0x02001C0A RID: 7178
		[Token(Token = "0x2001C0A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FB5FC", Offset = "0x10FB5FC")]
		private sealed class <>c__DisplayClass16_0
		{
			// Token: 0x06009C3D RID: 39997 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009C3D")]
			[Address(RVA = "0x1D5C2C8", Offset = "0x1D5C2C8", VA = "0x7BBC55C2C8")]
			public <>c__DisplayClass16_0()
			{
			}

			// Token: 0x06009C3E RID: 39998 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009C3E")]
			[Address(RVA = "0x1D5C450", Offset = "0x1D5C450", VA = "0x7BBC55C450")]
			internal void <PlayKillEffect>b__0()
			{
			}

			// Token: 0x0400A224 RID: 41508
			[Token(Token = "0x400A224")]
			[FieldOffset(Offset = "0x10")]
			public GameObject flyEffect;

			// Token: 0x0400A225 RID: 41509
			[Token(Token = "0x400A225")]
			[FieldOffset(Offset = "0x18")]
			public Vector3 targetPos;
		}
	}
}
