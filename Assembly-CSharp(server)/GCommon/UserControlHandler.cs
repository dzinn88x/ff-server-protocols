using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000F02 RID: 3842
	[Token(Token = "0x2000F02")]
	internal class UserControlHandler
	{
		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x060035F5 RID: 13813 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060035F6 RID: 13814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006B8")]
		public float[] RawDataCache
		{
			[Token(Token = "0x60035F5")]
			[Address(RVA = "0x22453E8", Offset = "0x22453E8", VA = "0x7BBCA453E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60035F6")]
			[Address(RVA = "0x22453F0", Offset = "0x22453F0", VA = "0x7BBCA453F0")]
			private set
			{
			}
		}

		// Token: 0x060035F7 RID: 13815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035F7")]
		[Address(RVA = "0x22453F4", Offset = "0x22453F4", VA = "0x7BBCA453F4")]
		public UserControlHandler()
		{
		}

		// Token: 0x060035F8 RID: 13816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035F8")]
		[Address(RVA = "0x224669C", Offset = "0x224669C", VA = "0x7BBCA4669C")]
		public void SetRecordTouchInfoEnable(bool enable)
		{
		}

		// Token: 0x060035F9 RID: 13817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035F9")]
		[Address(RVA = "0x22467E8", Offset = "0x22467E8", VA = "0x7BBCA467E8")]
		public void SetButtonEnable(bool enable)
		{
		}

		// Token: 0x060035FA RID: 13818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035FA")]
		[Address(RVA = "0x22467F4", Offset = "0x22467F4", VA = "0x7BBCA467F4")]
		public void ResetButton(int key)
		{
		}

		// Token: 0x060035FB RID: 13819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035FB")]
		[Address(RVA = "0x2246888", Offset = "0x2246888", VA = "0x7BBCA46888")]
		public void AddAxisData(int hKey, int vKey, float acturallyMovedDist, UserControlAxisData.EAxisDataType t)
		{
		}

		// Token: 0x060035FC RID: 13820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035FC")]
		[Address(RVA = "0x2246A54", Offset = "0x2246A54", VA = "0x7BBCA46A54")]
		public void UpdateAxis(float gameTime, float deltaTime)
		{
		}

		// Token: 0x060035FD RID: 13821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035FD")]
		[Address(RVA = "0x2246F70", Offset = "0x2246F70", VA = "0x7BBCA46F70")]
		public void Update(float gameTime, float deltaTime)
		{
		}

		// Token: 0x060035FE RID: 13822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035FE")]
		[Address(RVA = "0x224779C", Offset = "0x224779C", VA = "0x7BBCA4779C")]
		private void RecordTouchInfo()
		{
		}

		// Token: 0x060035FF RID: 13823 RVA: 0x00010590 File Offset: 0x0000E790
		[Token(Token = "0x60035FF")]
		[Address(RVA = "0x2247F9C", Offset = "0x2247F9C", VA = "0x7BBCA47F9C")]
		public bool IsAuxAimBtnDown()
		{
			return default(bool);
		}

		// Token: 0x06003600 RID: 13824 RVA: 0x000105A8 File Offset: 0x0000E7A8
		[Token(Token = "0x6003600")]
		[Address(RVA = "0x2247FA4", Offset = "0x2247FA4", VA = "0x7BBCA47FA4")]
		public bool IsButtonDown(int key)
		{
			return default(bool);
		}

		// Token: 0x06003601 RID: 13825 RVA: 0x000105C0 File Offset: 0x0000E7C0
		[Token(Token = "0x6003601")]
		[Address(RVA = "0x2248010", Offset = "0x2248010", VA = "0x7BBCA48010")]
		public bool IsButtonUp(int key)
		{
			return default(bool);
		}

		// Token: 0x06003602 RID: 13826 RVA: 0x000105D8 File Offset: 0x0000E7D8
		[Token(Token = "0x6003602")]
		[Address(RVA = "0x224807C", Offset = "0x224807C", VA = "0x7BBCA4807C")]
		public bool IsButtonReleased(int key)
		{
			return default(bool);
		}

		// Token: 0x06003603 RID: 13827 RVA: 0x000105F0 File Offset: 0x0000E7F0
		[Token(Token = "0x6003603")]
		[Address(RVA = "0x2248134", Offset = "0x2248134", VA = "0x7BBCA48134")]
		public bool IsButtonPressed(int key)
		{
			return default(bool);
		}

		// Token: 0x06003604 RID: 13828 RVA: 0x00010608 File Offset: 0x0000E808
		[Token(Token = "0x6003604")]
		[Address(RVA = "0x22481EC", Offset = "0x22481EC", VA = "0x7BBCA481EC")]
		public bool HaveRecoredTouchPosition()
		{
			return default(bool);
		}

		// Token: 0x06003605 RID: 13829 RVA: 0x00010620 File Offset: 0x0000E820
		[Token(Token = "0x6003605")]
		[Address(RVA = "0x22482D8", Offset = "0x22482D8", VA = "0x7BBCA482D8")]
		public Vector3 GetRecordedTouchPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06003606 RID: 13830 RVA: 0x00010638 File Offset: 0x0000E838
		[Token(Token = "0x6003606")]
		[Address(RVA = "0x22483EC", Offset = "0x22483EC", VA = "0x7BBCA483EC")]
		public bool IsUserControlChanged()
		{
			return default(bool);
		}

		// Token: 0x06003607 RID: 13831 RVA: 0x00010650 File Offset: 0x0000E850
		[Token(Token = "0x6003607")]
		[Address(RVA = "0x22483F4", Offset = "0x22483F4", VA = "0x7BBCA483F4")]
		public Vector3 GetDirectionLeft()
		{
			return default(Vector3);
		}

		// Token: 0x06003608 RID: 13832 RVA: 0x00010668 File Offset: 0x0000E868
		[Token(Token = "0x6003608")]
		[Address(RVA = "0x224844C", Offset = "0x224844C", VA = "0x7BBCA4844C")]
		public Vector3 GetAxisDeltaLeft()
		{
			return default(Vector3);
		}

		// Token: 0x06003609 RID: 13833 RVA: 0x00010680 File Offset: 0x0000E880
		[Token(Token = "0x6003609")]
		[Address(RVA = "0x22484A4", Offset = "0x22484A4", VA = "0x7BBCA484A4")]
		public Vector3 GetDirectionRight()
		{
			return default(Vector3);
		}

		// Token: 0x0600360A RID: 13834 RVA: 0x00010698 File Offset: 0x0000E898
		[Token(Token = "0x600360A")]
		[Address(RVA = "0x2248500", Offset = "0x2248500", VA = "0x7BBCA48500")]
		public Vector3 GetAxisDeltaRight()
		{
			return default(Vector3);
		}

		// Token: 0x0600360B RID: 13835 RVA: 0x000106B0 File Offset: 0x0000E8B0
		[Token(Token = "0x600360B")]
		[Address(RVA = "0x224855C", Offset = "0x224855C", VA = "0x7BBCA4855C")]
		public Vector3 GetDirectionWeaponSlider()
		{
			return default(Vector3);
		}

		// Token: 0x0600360C RID: 13836 RVA: 0x000106C8 File Offset: 0x0000E8C8
		[Token(Token = "0x600360C")]
		[Address(RVA = "0x224865C", Offset = "0x224865C", VA = "0x7BBCA4865C")]
		public Vector3 GetAxisDeltaWeaponSlider()
		{
			return default(Vector3);
		}

		// Token: 0x0600360D RID: 13837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600360D")]
		[Address(RVA = "0x22486B8", Offset = "0x22486B8", VA = "0x7BBCA486B8")]
		public UserControlAxisData GetAxisData(int axisIndex)
		{
			return null;
		}

		// Token: 0x0600360E RID: 13838 RVA: 0x000106E0 File Offset: 0x0000E8E0
		[Token(Token = "0x600360E")]
		[Address(RVA = "0x224870C", Offset = "0x224870C", VA = "0x7BBCA4870C")]
		public Vector3 GetShiftedDirectionWithCamera(Camera camera, int axisIndex = 0)
		{
			return default(Vector3);
		}

		// Token: 0x0600360F RID: 13839 RVA: 0x000106F8 File Offset: 0x0000E8F8
		[Token(Token = "0x600360F")]
		[Address(RVA = "0x2247B00", Offset = "0x2247B00", VA = "0x7BBCA47B00")]
		private bool IsAxisChanged(Vector3 curVec, Vector3 lastVec)
		{
			return default(bool);
		}

		// Token: 0x06003610 RID: 13840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003610")]
		[Address(RVA = "0x2246BA0", Offset = "0x2246BA0", VA = "0x7BBCA46BA0")]
		private void UpdateAxis(int axisIndex)
		{
		}

		// Token: 0x06003611 RID: 13841 RVA: 0x00010710 File Offset: 0x0000E910
		[Token(Token = "0x6003611")]
		[Address(RVA = "0x2248900", Offset = "0x2248900", VA = "0x7BBCA48900")]
		private bool OnTouchBegin(UserControlAxisData axisData)
		{
			return default(bool);
		}

		// Token: 0x06003612 RID: 13842 RVA: 0x00010728 File Offset: 0x0000E928
		[Token(Token = "0x6003612")]
		[Address(RVA = "0x22489D4", Offset = "0x22489D4", VA = "0x7BBCA489D4")]
		private bool OnTouchMove(UserControlAxisData axisData)
		{
			return default(bool);
		}

		// Token: 0x06003613 RID: 13843 RVA: 0x00010740 File Offset: 0x0000E940
		[Token(Token = "0x6003613")]
		[Address(RVA = "0x2248B70", Offset = "0x2248B70", VA = "0x7BBCA48B70")]
		private bool OnTouchStationary(UserControlAxisData axisData)
		{
			return default(bool);
		}

		// Token: 0x06003614 RID: 13844 RVA: 0x00010758 File Offset: 0x0000E958
		[Token(Token = "0x6003614")]
		[Address(RVA = "0x2248AD4", Offset = "0x2248AD4", VA = "0x7BBCA48AD4")]
		private bool OnTouchEnd(UserControlAxisData axisData)
		{
			return default(bool);
		}

		// Token: 0x06003615 RID: 13845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003615")]
		[Address(RVA = "0x2248C8C", Offset = "0x2248C8C", VA = "0x7BBCA48C8C")]
		private void UpdateSpeedUpStates(UserControlAxisData axisData, TouchPhase tp)
		{
		}

		// Token: 0x06003616 RID: 13846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003616")]
		[Address(RVA = "0x2248C3C", Offset = "0x2248C3C", VA = "0x7BBCA48C3C")]
		private void CleanupTouchData(UserControlAxisData axisData)
		{
		}

		// Token: 0x06003617 RID: 13847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003617")]
		[Address(RVA = "0x2248CC4", Offset = "0x2248CC4", VA = "0x7BBCA48CC4")]
		public void SetFingerDashArea(int area)
		{
		}

		// Token: 0x06003618 RID: 13848 RVA: 0x00010770 File Offset: 0x0000E970
		[Token(Token = "0x6003618")]
		[Address(RVA = "0x2248CCC", Offset = "0x2248CCC", VA = "0x7BBCA48CCC")]
		public bool IsFingerInDashArea()
		{
			return default(bool);
		}

		// Token: 0x06003619 RID: 13849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003619")]
		[Address(RVA = "0x2248CEC", Offset = "0x2248CEC", VA = "0x7BBCA48CEC")]
		public void SetLockFingerInDashArea(bool isLock)
		{
		}

		// Token: 0x0600361A RID: 13850 RVA: 0x00010788 File Offset: 0x0000E988
		[Token(Token = "0x600361A")]
		[Address(RVA = "0x2248CF8", Offset = "0x2248CF8", VA = "0x7BBCA48CF8")]
		public bool GetLockFingerInDashArea()
		{
			return default(bool);
		}

		// Token: 0x04004943 RID: 18755
		[Token(Token = "0x4004943")]
		[FieldOffset(Offset = "0x10")]
		private UserControlMapping m_UserControlMapping;

		// Token: 0x04004944 RID: 18756
		[Token(Token = "0x4004944")]
		[FieldOffset(Offset = "0x18")]
		private float[] m_RawDataCache;

		// Token: 0x04004945 RID: 18757
		[Token(Token = "0x4004945")]
		[FieldOffset(Offset = "0x20")]
		private bool m_IsButtonEnable;

		// Token: 0x04004946 RID: 18758
		[Token(Token = "0x4004946")]
		[FieldOffset(Offset = "0x28")]
		private UserControlAxisData[] m_AxisData;

		// Token: 0x04004947 RID: 18759
		[Token(Token = "0x4004947")]
		[FieldOffset(Offset = "0x30")]
		private float[] m_LastRawDataCache;

		// Token: 0x04004948 RID: 18760
		[Token(Token = "0x4004948")]
		[FieldOffset(Offset = "0x38")]
		private bool m_IsUserControlChanged;

		// Token: 0x04004949 RID: 18761
		[Token(Token = "0x4004949")]
		[FieldOffset(Offset = "0x40")]
		private UserControlTouchData m_CurrentTouchData;

		// Token: 0x0400494A RID: 18762
		[Token(Token = "0x400494A")]
		[FieldOffset(Offset = "0x48")]
		private bool m_EnableRecordTouchInfo;

		// Token: 0x0400494B RID: 18763
		[Token(Token = "0x400494B")]
		[FieldOffset(Offset = "0x4C")]
		private int m_FingerInDashArea;

		// Token: 0x0400494C RID: 18764
		[Token(Token = "0x400494C")]
		[FieldOffset(Offset = "0x50")]
		private bool m_LockFingerInDashArea;

		// Token: 0x0400494D RID: 18765
		[Token(Token = "0x400494D")]
		public const int SPEEDUP_LOCK_THRESHOLD = 3;

		// Token: 0x0400494E RID: 18766
		[Token(Token = "0x400494E")]
		[FieldOffset(Offset = "0x0")]
		public static float m_resolutionResetScale;

		// Token: 0x0400494F RID: 18767
		[Token(Token = "0x400494F")]
		[FieldOffset(Offset = "0x51")]
		private bool m_HasAxisHandled;
	}
}
