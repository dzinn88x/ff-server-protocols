using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace GCommon
{
	// Token: 0x02000EFE RID: 3838
	[Token(Token = "0x2000EFE")]
	public class UserControlAxisData
	{
		// Token: 0x060035DA RID: 13786 RVA: 0x00010440 File Offset: 0x0000E640
		[Token(Token = "0x60035DA")]
		[Address(RVA = "0x2244590", Offset = "0x2244590", VA = "0x7BBCA44590")]
		public UserControlAxisData.EAxisDataType GetAxisDataType()
		{
			return UserControlAxisData.EAxisDataType.Left;
		}

		// Token: 0x060035DB RID: 13787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035DB")]
		[Address(RVA = "0x2244598", Offset = "0x2244598", VA = "0x7BBCA44598")]
		public UserControlAxisData(string hName, string vName, float acturallyMovedDist, UserControlAxisData.EAxisDataType t)
		{
		}

		// Token: 0x060035DC RID: 13788 RVA: 0x00010458 File Offset: 0x0000E658
		[Token(Token = "0x60035DC")]
		[Address(RVA = "0x2244814", Offset = "0x2244814", VA = "0x7BBCA44814")]
		public int GetTouchFinger()
		{
			return 0;
		}

		// Token: 0x060035DD RID: 13789 RVA: 0x00010470 File Offset: 0x0000E670
		[Token(Token = "0x60035DD")]
		[Address(RVA = "0x2244840", Offset = "0x2244840", VA = "0x7BBCA44840")]
		public bool IsInRange(Vector3 v)
		{
			return default(bool);
		}

		// Token: 0x060035DE RID: 13790 RVA: 0x00010488 File Offset: 0x0000E688
		[Token(Token = "0x60035DE")]
		[Address(RVA = "0x22448DC", Offset = "0x22448DC", VA = "0x7BBCA448DC")]
		private bool IsButtonArea(Vector3 v)
		{
			return default(bool);
		}

		// Token: 0x060035DF RID: 13791 RVA: 0x000104A0 File Offset: 0x0000E6A0
		[Token(Token = "0x60035DF")]
		[Address(RVA = "0x2244A78", Offset = "0x2244A78", VA = "0x7BBCA44A78")]
		public bool IsStationary()
		{
			return default(bool);
		}

		// Token: 0x060035E0 RID: 13792 RVA: 0x000104B8 File Offset: 0x0000E6B8
		[Token(Token = "0x60035E0")]
		[Address(RVA = "0x2244ABC", Offset = "0x2244ABC", VA = "0x7BBCA44ABC")]
		public bool CanTouchingThrough(Vector2 pos)
		{
			return default(bool);
		}

		// Token: 0x060035E1 RID: 13793 RVA: 0x000104D0 File Offset: 0x0000E6D0
		[Token(Token = "0x60035E1")]
		[Address(RVA = "0x2244CD4", Offset = "0x2244CD4", VA = "0x7BBCA44CD4")]
		public bool IsSpeedupButtonArea(Vector3 v)
		{
			return default(bool);
		}

		// Token: 0x060035E2 RID: 13794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035E2")]
		[Address(RVA = "0x2244DBC", Offset = "0x2244DBC", VA = "0x7BBCA44DBC")]
		public void UpdateValue(Vector3 pos, Vector3 deltaValue)
		{
		}

		// Token: 0x060035E3 RID: 13795 RVA: 0x000104E8 File Offset: 0x0000E6E8
		[Token(Token = "0x60035E3")]
		[Address(RVA = "0x2244DD0", Offset = "0x2244DD0", VA = "0x7BBCA44DD0")]
		public Vector3 GetCurrentScreenPos()
		{
			return default(Vector3);
		}

		// Token: 0x060035E4 RID: 13796 RVA: 0x00010500 File Offset: 0x0000E700
		[Token(Token = "0x60035E4")]
		[Address(RVA = "0x2244DDC", Offset = "0x2244DDC", VA = "0x7BBCA44DDC")]
		public bool CheckIsInBegin()
		{
			return default(bool);
		}

		// Token: 0x060035E5 RID: 13797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035E5")]
		[Address(RVA = "0x2244DE4", Offset = "0x2244DE4", VA = "0x7BBCA44DE4")]
		public void OnBegin(Vector3 startPos, Vector3 deltaPos)
		{
		}

		// Token: 0x060035E6 RID: 13798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035E6")]
		[Address(RVA = "0x2244EA4", Offset = "0x2244EA4", VA = "0x7BBCA44EA4")]
		public void OnEnd()
		{
		}

		// Token: 0x060035E7 RID: 13799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035E7")]
		[Address(RVA = "0x2244F88", Offset = "0x2244F88", VA = "0x7BBCA44F88")]
		public void OnMove(Vector3 lastPos, Vector3 curPos)
		{
		}

		// Token: 0x060035E8 RID: 13800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035E8")]
		[Address(RVA = "0x2245158", Offset = "0x2245158", VA = "0x7BBCA45158")]
		public void OnStationary(Vector3 curPos)
		{
		}

		// Token: 0x060035E9 RID: 13801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035E9")]
		[Address(RVA = "0x22451EC", Offset = "0x22451EC", VA = "0x7BBCA451EC")]
		public void UpdateDirection()
		{
		}

		// Token: 0x060035EA RID: 13802 RVA: 0x00010518 File Offset: 0x0000E718
		[Token(Token = "0x60035EA")]
		[Address(RVA = "0x2245208", Offset = "0x2245208", VA = "0x7BBCA45208")]
		public Vector3 GetDelta()
		{
			return default(Vector3);
		}

		// Token: 0x060035EB RID: 13803 RVA: 0x00010530 File Offset: 0x0000E730
		[Token(Token = "0x60035EB")]
		[Address(RVA = "0x2245214", Offset = "0x2245214", VA = "0x7BBCA45214")]
		public bool IsTouched()
		{
			return default(bool);
		}

		// Token: 0x060035EC RID: 13804 RVA: 0x00010548 File Offset: 0x0000E748
		[Token(Token = "0x60035EC")]
		[Address(RVA = "0x224521C", Offset = "0x224521C", VA = "0x7BBCA4521C")]
		public Vector3 GetStartScreenPos()
		{
			return default(Vector3);
		}

		// Token: 0x060035ED RID: 13805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035ED")]
		[Address(RVA = "0x2245228", Offset = "0x2245228", VA = "0x7BBCA45228")]
		public void SetVirtualAxes()
		{
		}

		// Token: 0x060035EE RID: 13806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035EE")]
		[Address(RVA = "0x224528C", Offset = "0x224528C", VA = "0x7BBCA4528C")]
		public void AddTouchingThroughArea(int key, UserButtonArea area)
		{
		}

		// Token: 0x060035EF RID: 13807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035EF")]
		[Address(RVA = "0x2245344", Offset = "0x2245344", VA = "0x7BBCA45344")]
		public void EnableTouchingThroughArea(int key, bool v)
		{
		}

		// Token: 0x04004927 RID: 18727
		[Token(Token = "0x4004927")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 Direction;

		// Token: 0x04004928 RID: 18728
		[Token(Token = "0x4004928")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 DeltaPos;

		// Token: 0x04004929 RID: 18729
		[Token(Token = "0x4004929")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 LastDirection;

		// Token: 0x0400492A RID: 18730
		[Token(Token = "0x400492A")]
		[FieldOffset(Offset = "0x38")]
		public UserControlTouchInfo TouchInfo;

		// Token: 0x0400492B RID: 18731
		[Token(Token = "0x400492B")]
		[FieldOffset(Offset = "0x40")]
		public UserControlTouchInfo LastTouchInfo;

		// Token: 0x0400492C RID: 18732
		[Token(Token = "0x400492C")]
		[FieldOffset(Offset = "0x48")]
		private bool m_IsTouched;

		// Token: 0x0400492D RID: 18733
		[Token(Token = "0x400492D")]
		[FieldOffset(Offset = "0x49")]
		private bool m_IsActuallyMoved;

		// Token: 0x0400492E RID: 18734
		[Token(Token = "0x400492E")]
		[FieldOffset(Offset = "0x4A")]
		private bool m_IsInBegin;

		// Token: 0x0400492F RID: 18735
		[Token(Token = "0x400492F")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 m_CurrentDeltaValue;

		// Token: 0x04004930 RID: 18736
		[Token(Token = "0x4004930")]
		[FieldOffset(Offset = "0x58")]
		private Vector3 m_StartScreenPos;

		// Token: 0x04004931 RID: 18737
		[Token(Token = "0x4004931")]
		[FieldOffset(Offset = "0x64")]
		private Vector3 m_CurrentScreenPos;

		// Token: 0x04004932 RID: 18738
		[Token(Token = "0x4004932")]
		[FieldOffset(Offset = "0x70")]
		private float m_ActuallyMovedDistance;

		// Token: 0x04004933 RID: 18739
		[Token(Token = "0x4004933")]
		[FieldOffset(Offset = "0x74")]
		public Vector3 SwipeDirection;

		// Token: 0x04004934 RID: 18740
		[Token(Token = "0x4004934")]
		[FieldOffset(Offset = "0x80")]
		private UserControlAxisData.EAxisDataType m_AxisDataType;

		// Token: 0x04004935 RID: 18741
		[Token(Token = "0x4004935")]
		[FieldOffset(Offset = "0x88")]
		private Dictionary<int, UserButtonArea> m_TouchingThroughArea;

		// Token: 0x04004936 RID: 18742
		[Token(Token = "0x4004936")]
		[FieldOffset(Offset = "0x90")]
		private CrossPlatformInputManager.VirtualAxis m_HVirtualAxis;

		// Token: 0x04004937 RID: 18743
		[Token(Token = "0x4004937")]
		[FieldOffset(Offset = "0x98")]
		private CrossPlatformInputManager.VirtualAxis m_VVirtualAxis;

		// Token: 0x02000EFF RID: 3839
		[Token(Token = "0x2000EFF")]
		public enum EAxisDataType
		{
			// Token: 0x04004939 RID: 18745
			[Token(Token = "0x4004939")]
			Left,
			// Token: 0x0400493A RID: 18746
			[Token(Token = "0x400493A")]
			Right,
			// Token: 0x0400493B RID: 18747
			[Token(Token = "0x400493B")]
			WeaponSlider
		}
	}
}
