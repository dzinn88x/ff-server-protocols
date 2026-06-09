using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020B8 RID: 8376
	[Token(Token = "0x20020B8")]
	public class ElitePassSpecialChallengeView : MonoBehaviour
	{
		// Token: 0x0600BC7A RID: 48250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC7A")]
		[Address(RVA = "0x1B84E40", Offset = "0x1B84E40", VA = "0x7BBC384E40")]
		private void Start()
		{
		}

		// Token: 0x0600BC7B RID: 48251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC7B")]
		[Address(RVA = "0x1B84EF4", Offset = "0x1B84EF4", VA = "0x7BBC384EF4")]
		public void SetData(EPChallengeInfo info)
		{
		}

		// Token: 0x0600BC7C RID: 48252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC7C")]
		[Address(RVA = "0x1B84FB8", Offset = "0x1B84FB8", VA = "0x7BBC384FB8")]
		public void SetDataForNormalMark(bool isUnlocked)
		{
		}

		// Token: 0x0600BC7D RID: 48253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC7D")]
		[Address(RVA = "0x1B85064", Offset = "0x1B85064", VA = "0x7BBC385064")]
		public void OnClickToUnlockButton()
		{
		}

		// Token: 0x0600BC7E RID: 48254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC7E")]
		[Address(RVA = "0x1B852B4", Offset = "0x1B852B4", VA = "0x7BBC3852B4")]
		public ElitePassSpecialChallengeView()
		{
		}

		// Token: 0x0400BD13 RID: 48403
		[Token(Token = "0x400BD13")]
		[FieldOffset(Offset = "0x18")]
		public GameObject SpecialUnlocked;

		// Token: 0x0400BD14 RID: 48404
		[Token(Token = "0x400BD14")]
		[FieldOffset(Offset = "0x20")]
		public GameObject SpecialToUnlock;

		// Token: 0x0400BD15 RID: 48405
		[Token(Token = "0x400BD15")]
		[FieldOffset(Offset = "0x28")]
		public GameObject NormalChallengeMark;

		// Token: 0x0400BD16 RID: 48406
		[Token(Token = "0x400BD16")]
		[FieldOffset(Offset = "0x30")]
		public GameObject NormalChallengeMarkLocked;

		// Token: 0x0400BD17 RID: 48407
		[Token(Token = "0x400BD17")]
		[FieldOffset(Offset = "0x38")]
		public UIButton m_ToUnlockButton;

		// Token: 0x0400BD18 RID: 48408
		[Token(Token = "0x400BD18")]
		[FieldOffset(Offset = "0x40")]
		private EPChallengeInfo m_CurChallengeInfo;
	}
}
