using System;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C58 RID: 7256
	[Token(Token = "0x2001C58")]
	public class LastVehicleObject : MonoBehaviour
	{
		// Token: 0x06009DF3 RID: 40435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DF3")]
		[Address(RVA = "0x13FEBF0", Offset = "0x13FEBF0", VA = "0x7BBBBFEBF0")]
		public void BindVehicleAndShow(uint vehicleObjID)
		{
		}

		// Token: 0x06009DF4 RID: 40436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DF4")]
		[Address(RVA = "0x13FF0C0", Offset = "0x13FF0C0", VA = "0x7BBBBFF0C0")]
		public void HideObject(bool needDelay = false)
		{
		}

		// Token: 0x06009DF5 RID: 40437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DF5")]
		[Address(RVA = "0x13FF224", Offset = "0x13FF224", VA = "0x7BBBBFF224")]
		private void OnHide()
		{
		}

		// Token: 0x06009DF6 RID: 40438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DF6")]
		[Address(RVA = "0x13FF310", Offset = "0x13FF310", VA = "0x7BBBBFF310")]
		public void Update()
		{
		}

		// Token: 0x06009DF7 RID: 40439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DF7")]
		[Address(RVA = "0x13FEE20", Offset = "0x13FEE20", VA = "0x7BBBBFEE20")]
		private void UpdatePositionAndRotation()
		{
		}

		// Token: 0x06009DF8 RID: 40440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DF8")]
		[Address(RVA = "0x13FF398", Offset = "0x13FF398", VA = "0x7BBBBFF398")]
		public LastVehicleObject()
		{
		}

		// Token: 0x0400A42C RID: 42028
		[Token(Token = "0x400A42C")]
		private const float DELAY_SECOUNDS = 2f;

		// Token: 0x0400A42D RID: 42029
		[Token(Token = "0x400A42D")]
		[FieldOffset(Offset = "0x18")]
		private Vehicle m_BindVehicle;

		// Token: 0x0400A42E RID: 42030
		[Token(Token = "0x400A42E")]
		[FieldOffset(Offset = "0x20")]
		private uint m_HideDelayCallID;
	}
}
